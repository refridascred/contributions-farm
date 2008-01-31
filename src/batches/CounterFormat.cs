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

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7150;
        public const long BaseProfile = 501;
        public const long SoftProfile = 1357;
        public const long MaxProfile = 6471;
        public const double BurstProfile = 52.95;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
