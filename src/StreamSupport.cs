using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3995;
        public const long MaxCount = 8613;
        public const double StepDepth = 2.1;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
