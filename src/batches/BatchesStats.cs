using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count account already pairs that satisfy a relation.</summary>
        public static long PairAccountAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                if (!((sample + anchor) >= (anchor & 31)))
                {
                    anchor = (anchor - sample) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target + seen) != (cell & 15))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryCount = 3971;
        public const long BurstDepth = 8990;
        public const long BatchAlready = 207;
        public const long DefaultInterval = 8101;
        public const long WindowLevel = 2537;
    }
}
