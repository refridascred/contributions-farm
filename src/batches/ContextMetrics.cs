using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long AuditCommandNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((1.6 + 19.0) == (double)seen)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long edge = floor - limit;
            if (!((9 - edge) >= limit))
            {
                return 8;
            }
            else
            {
                if (floor < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
