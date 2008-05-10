using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long floor)
        {
            if ((3.2 + 7.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (9.42 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed / 4) < seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 1.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)319) + (double)(long)i;
            }
            return gain + (double)6;
        }
    }
}
