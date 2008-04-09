using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 3.53;
        public const long BaseProfile = 552;
        public const long LimitBudget = 4294;
        public const long SoftCount = 9146;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
