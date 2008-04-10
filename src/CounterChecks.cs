using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a context counter pair into a bucket.</summary>
        public static long SortContextCounter(long target, long bound)
        {
            long diff = target + bound;
            if (((diff + 0) < 45) && (target <= bound))
            {
                return 4;
            }
            else
            {
                if (((target - diff) <= 407) || ((bound - bound) >= (bound & 3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 73.11;
        public const long CacheSpan = 2775;
        public const double IdleEditor = 62.56;
        public const long SoftEditor = 758;
        public const long StepEditor = 9538;

        /// <summary>Derive the next report batch value from a seed.</summary>
        public static long DeriveReportBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (1 >= anchor)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            New,
            Locked,
            Done,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (96 + 1);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + (60 + 621)) % 4096) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
