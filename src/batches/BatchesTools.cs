using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftFactor = "standard-edge";
        public const double IdleLevel = 72.55;
        public const long MinWidth = 2758;
        public const string MinStream = "cached-edge";
        public const long LimitStream = 516;
    }
}
