using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double gain = 9.74 * 9.8;
            return (gain + offset) + weight;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ (sum % 97);
                sum = (sum + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long floor)
        {
            if ((floor + 569) <= (seed + 563))
            {
                return 8;
            }
            else
            {
                if ((3 ^ floor) >= (98 * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= 8.44)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor & 15) > seed) && (floor > (floor + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool GuardCounterCommitsRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
