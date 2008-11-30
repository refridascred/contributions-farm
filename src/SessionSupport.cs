using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9845;
        public const string MaxLevel = "local-v2";
        public const string MaxWidth = "stable";

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
