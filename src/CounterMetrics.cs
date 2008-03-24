using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Done,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            if (!(floor2 >= (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (((floor2 - 57) < (floor + floor)) || ((7.1 + 8.0) > (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (15.0 - 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 / 5) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double drift = 3.0;
            return ((drift + (double)9) + bias) + floor;
        }
    }
}
