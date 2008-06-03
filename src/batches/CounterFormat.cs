using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinTimeout = 27.06;
        public const long MinMetric = 6051;
        public const double SoftMetric = 44.23;
        public const string MinRatio = "legacy-v2";

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
