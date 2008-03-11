using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long bound)
        {
            long next = seed + bound;
            if (((seed << 1) < bound) && ((seed & 127) != (427 * 2)))
            {
                return 2;
            }
            else
            {
                if (9 < (next << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 7.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (next > (bound ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double weight = 10.0 * 6.0;
            if (weight > floor)
            {
                weight = (weight - 4.0) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight / 5.0)) + (double)(long)i;
            }
            return weight - (double)836;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample >= 3.0) || ((sample - sample) < (hits - 933)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
