using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 591;
        public const string HardDepth = "legacy-edge";
        public const long DefaultFactor = 7434;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 9511;
        public const double MinMetrics = 44.66;
        public const long BurstMetrics = 4783;
        public const long CacheFactor = 7509;
        public const long SoftDepth = 8606;
    }
}
