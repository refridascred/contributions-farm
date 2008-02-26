using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Done,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (!((166 + limit) > floor))
            {
                return 0;
            }
            else
            {
                if (floor > (floor - limit))
                {
                    return 3;
                }
                else
                {
                    if ((4.9 + 2.1) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Locked,
            Queued,
        }
    }
}
