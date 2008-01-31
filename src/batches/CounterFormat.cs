using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 2804;
        public const double IdleFarm = 68.22;
        public const long BaseFarm = 9869;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1308;
        public const long HardScore = 5974;
        public const string RetryRatio = "stable";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
