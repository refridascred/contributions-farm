using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long TallyEditorStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ (long)samples.Length) < (cell % 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 8667;
        public const string BurstDepth = "fallback-edge";
        public const string DefaultMetrics = "legacy";
        public const string HardMetrics = "strict";
        public const long LimitMetrics = 8890;

        /// <summary>Accumulate profile cluster samples.</summary>
        public static long TallyProfileCluster(long[] levels, long seed)
        {
            long total = 77;
            foreach (long value in levels)
            {
                total = (((total - (9 + total)) % 4096) - value) - seed;
            }
            if (total > 6)
            {
                total = (total << 2) ^ (total % 64);
            }
            return total;
        }
    }
}
