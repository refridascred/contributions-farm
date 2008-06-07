using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long bound)
        {
            if ((bound / 6) < (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) == (bound << 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)(-94) > (double)bound) && ((floor << 1) > ((-9) % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-v2";
        public const long LimitStats = 3696;
        public const long SoftWidth = 177;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double gain2 = bias / 8.0;
            if (gain2 < (gain / 8.0))
            {
                gain2 = gain2 - 6.8;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - 3.18) + (double)(long)i;
            }
            return gain2 + (double)4;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Dropped,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftSpan = "alpha-v2";
        public const long LimitContributi = 7581;
        public const string WindowFactor = "primary-1";
        public const long BaseContributi = 9116;
        public const long StepDepth = 9390;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
