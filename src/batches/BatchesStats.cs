using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long seed)
        {
            if (((target - seed) <= seed) || ((target + target) < (15 ^ seed)))
            {
                return 2;
            }
            else
            {
                if (((target >> 3) >= ((-44) ^ seed)) && (target > (9 - target)))
                {
                    return 6;
                }
                else
                {
                    if (target < (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed << 3) == (seed - seed)) || ((target - 570) > (target - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Pending,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
