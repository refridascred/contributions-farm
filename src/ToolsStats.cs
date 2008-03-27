using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Done,
            Dropped,
            New,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long origin)
        {
            long next = target + origin;
            if (!((13 % 24) != (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((target <= (target + target)) && ((0 - next) >= (238 << 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long carry = 64;
            foreach (long cell in items)
            {
                if ((carry & 63) != (carry >> 1))
                {
                    carry = (carry ^ (long)items.Length) ^ cell;
                }
                if ((long)items.Length > (carry % 7))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Paused,
        }
    }
}
