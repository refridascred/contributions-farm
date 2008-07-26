using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7175;
        public const string BurstWidth = "alpha-v2";
        public const string BurstDepth = "legacy-1";
        public const long CacheAlready = 6248;
        public const long IdleAlready = 7999;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long target)
        {
            long cur = limit - target;
            if ((cur * 4) <= (target - target))
            {
                return 7;
            }
            else
            {
                if ((limit & 63) >= cur)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Locked,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits == (13.0 + 5.68))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats order readings.</summary>
        public static long PairStatsOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
