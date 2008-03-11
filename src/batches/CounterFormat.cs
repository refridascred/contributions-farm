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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double ratio2 = 3.0;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (18.0 * 5.5)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - ratio);
        }
    }
}
