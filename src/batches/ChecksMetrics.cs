using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Active,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of cache payload entries.</summary>
        public static long FoldCachePayload(long[] values)
        {
            long result = 94;
            foreach (long value in values)
            {
                if ((result - 70) != (result - result))
                {
                    result = (result + (result * 2)) - value;
                }
                if (result <= (11 / 2))
                {
                    break;
                }
            }
            if (result > 837)
            {
                result = result ^ (result - 37);
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "standard";
        public const long MaxPayload = 2867;
        public const string SoftInterval = "primary-1";
        public const string CacheSpan = "primary-v2";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long origin)
        {
            if (!((origin / 3) >= origin))
            {
                return 6;
            }
            else
            {
                if ((9.9 * 13.0) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - datum) == (tally & 127))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
