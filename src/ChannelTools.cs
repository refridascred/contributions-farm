using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long step)
        {
            if ((step <= (limit >> 1)) || ((limit & 63) == (limit / 6)))
            {
                return 6;
            }
            else
            {
                if (1.0 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            if (((8 / 9) > (step + 57)) || ((step << 3) > floor))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
