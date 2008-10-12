using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitInterval = "standard-v2";
        public const long MaxMetric = 126;
        public const double WindowWidth = 77.09;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long limit)
        {
            if ((floor >> 5) > floor)
            {
                return 2;
            }
            else
            {
                if (!((double)247 == (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit / 9) > floor) || ((double)limit != (0.71 + 8.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Closed,
            Pending,
            Queued,
            Retry,
        }
    }
}
