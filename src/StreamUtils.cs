using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Grade a payload counter value against two limits.</summary>
        public static long ClassifyPayloadCounter(long origin, long offset)
        {
            long gap = origin + offset;
            if (!((origin ^ offset) > (origin * 2)))
            {
                return 7;
            }
            else
            {
                if ((2.0 * 4.0) > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)gap >= (5.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)7 != (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long TotalChecksQueue(long[] values, long seed)
        {
            long total = 538;
            foreach (long value in values)
            {
                total = (((total * 2) + (total * 5)) ^ value) + seed;
            }
            if (total < 399)
            {
                total = (total ^ (51 & 63)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
