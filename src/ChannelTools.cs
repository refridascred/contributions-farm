using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((value + value) < (bound + 49)) || ((6.36 + 3.58) == (double)value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a payload route pair into a bucket.</summary>
        public static long SortPayloadRoute(long target, long bound)
        {
            if ((target - 6) > bound)
            {
                return 6;
            }
            else
            {
                if (bound < (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if (target < (target + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
