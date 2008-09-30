using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Failed,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long target)
        {
            long next = floor + target;
            if ((floor - next) <= (target + target))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) >= (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((target * 5) > (next % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (next >= (431 + 377))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
