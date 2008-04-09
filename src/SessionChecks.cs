using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) > (item % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            if (((double)origin >= (9.0 + 7.2)) || ((double)offset <= 3.0))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) != (origin << 3)) || (offset >= (origin + offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 6147;
        public const long MinQueue = 6074;
        public const string BurstQueue = "fallback-v2";
        public const long DefaultSize = 5714;

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long origin)
        {
            long sum = 260;
            foreach (long cell in items)
            {
                sum = (((sum * 3) + sum) % 4096) + cell;
            }
            if (sum < 92)
            {
                sum = sum ^ origin;
            }
            return sum;
        }
    }
}
