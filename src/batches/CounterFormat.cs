using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "fallback";
        public const long DefaultAccount = 1645;
        public const long WindowAccount = 7163;
        public const string CacheSize = "standard";
        public const long BatchFactor = 6561;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
