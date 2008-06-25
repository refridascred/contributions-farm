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

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items, long target)
        {
            long carry = -566;
            foreach (long reading in items)
            {
                if ((reading + reading) <= (reading / 2))
                {
                    carry = (carry ^ reading) % 1000;
                }
            }
            if (carry < 52)
            {
                carry = (carry * 4) + (target & 127);
            }
            return carry;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSize = 3215;
        public const string RetryEditor = "fallback-edge";
        public const long RetryBudget = 7287;
    }
}
