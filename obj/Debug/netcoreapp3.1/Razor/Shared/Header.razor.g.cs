#pragma checksum "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\Shared\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "966817f13dd36f89a20b09bd010edafdba6a1889"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorApplication1.Model;

#line default
#line hidden
#nullable disable
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar header-navbar p-0");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler bg-primary d-block");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\Shared\Header.razor"
                                                                OnToggleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div class=\"ml-3 font-weight-bold title pr-4\">BlazorApplication1</div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\User\source\repos\BlazorApplication1\BlazorApplication1\Shared\Header.razor"
       
    bool isDesktop = true, isToggled = true, isInitialized;

    [Parameter] public string StateCssClass { get; set; }
    [Parameter] public EventCallback<string> StateCssClassChanged { get; set; }

    protected override void OnInitialized()
    {
        NavigationManager.LocationChanged += OnLocationChanged;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JSRuntime.InvokeVoidAsync("windowMinWidthMatchesQuery", DotNetObjectReference.Create(this));
        isInitialized = true;
        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable]
    public async Task OnWindowMinWidthQueryChanged(bool matchesDesktop)
    {

        if (!isInitialized || isDesktop != matchesDesktop)
        {
            isDesktop = matchesDesktop;
            if (isInitialized || !isDesktop)
                await ToggleNavMenu(matchesDesktop);
        }
    }
    async Task OnToggleClick() => await ToggleNavMenu();

    async void OnLocationChanged(object sender, LocationChangedEventArgs args)
    {
        if (!isDesktop)
            await ToggleNavMenu(false);
    }

    async Task ToggleNavMenu(bool? value = null)
    {
        var newValue = value ?? !isToggled;
        isToggled = value ?? !isToggled;
        string stateCssClass = isToggled ? "expand" : "collapse";
        if (StateCssClass != stateCssClass)
        {
            StateCssClass = stateCssClass;
            await StateCssClassChanged.InvokeAsync(StateCssClass);
        }
    }
    public void Dispose()
    {
        NavigationManager.LocationChanged -= OnLocationChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
