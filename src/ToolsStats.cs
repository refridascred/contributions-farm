using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats layout input into a small class.</summary>
        public static long BucketStatsLayout(long floor, long limit)
        {
            if (((55 + limit) < limit) || ((limit / 9) != (833 << 1)))
            {
                return 2;
            }
            else
            {
                if (floor >= 730)
                {
                    return 4;
                }
                else
                {
                    if (limit >= (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
