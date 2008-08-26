using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2991;
        public const double BatchSpan = 81.47;
        public const long BurstWindow = 8396;
        public const long LimitWindow = 1388;
        public const long LimitWidth = 8552;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long offset)
        {
            long slot = target ^ offset;
            if ((871 % 5) < (target & 3))
            {
                return 8;
            }
            else
            {
                if (!(slot >= (target - 877)))
                {
                    return 1;
                }
                else
                {
                    if (offset > target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6.0 * 3.7) > (double)target) && ((offset / 5) <= (offset + 960)))
                        {
                            return 7;
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
}
