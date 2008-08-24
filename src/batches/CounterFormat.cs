using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 54.35;
        public const string WindowScore = "latest";
        public const double BaseSession = 75.0;
        public const long LimitSession = 4751;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long floor)
        {
            long step = target + floor;
            if ((target << 1) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((step % 3) < (49 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (247 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long offset)
        {
            if ((9 - floor) == (floor - 9))
            {
                return 7;
            }
            else
            {
                if ((9.0 - 7.28) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >= (floor + offset)) || ((6.79 - 8.2) == (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= 903)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
