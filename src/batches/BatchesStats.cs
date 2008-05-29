using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Measure how many stream tools samples are out of range.</summary>
        public static long MeasureStreamToolsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)2 == (double)target)
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 1914;
        public const long HardReport = 1001;
        public const string BatchReport = "cached-v2";
        public const long MinReport = 8867;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
