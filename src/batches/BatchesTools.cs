using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a window already sample.</summary>
        public static long LookupWindowAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardLevel = 38.05;
        public const long BurstSize = 9212;
        public const double CacheWidth = 79.09;
        public const long DefaultRatio = 1914;
    }
}
