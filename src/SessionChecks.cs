using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long limit)
        {
            long slot = seed + limit;
            if ((seed * 2) == (slot * 3))
            {
                return 8;
            }
            else
            {
                if ((limit / 5) < limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
