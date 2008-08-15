using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate tools account readings against a bound.</summary>
        public static bool GuardToolsAccountLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstLevel = 81.7;
        public const long WindowEditor = 9702;
        public const long CacheWidth = 5457;
        public const string LimitEditor = "latest-v2";
        public const string BurstSpan = "local";
    }
}
