using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2232;
        public const double IdleEntry = 79.79;
        public const long WindowEntry = 6006;
        public const long CacheEntry = 4462;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long step)
        {
            long slot = seed + step;
            if ((slot + (-89)) < (seed - step))
            {
                return 0;
            }
            else
            {
                if ((step << 1) >= 60)
                {
                    return 5;
                }
                else
                {
                    if (seed <= (seed + 591))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long total = 25;
            foreach (long item in values)
            {
                if ((double)total >= (8.9 / 5.0))
                {
                    total = (((total << 3) ^ item) % 101) + limit;
                }
                else
                {
                    total = (total * 5) + (total * 3);
                }
            }
            return total;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Dropped,
            Paused,
            Queued,
        }
    }
}
