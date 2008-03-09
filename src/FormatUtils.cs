using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long floor)
        {
            if ((7.4 / 6.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if ((step ^ floor) <= (floor / 3))
                {
                    return 8;
                }
                else
                {
                    if ((step / 5) == (floor & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + step) != (floor >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 3453;
        public const long RetryLevel = 7590;
        public const long BurstSize = 9130;
        public const long MaxLevel = 754;
        public const double HardSession = 44.46;

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool CheckFilterStreamBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
