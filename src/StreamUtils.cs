using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long score = 48;
            foreach (long entry in items)
            {
                if ((((-325) - entry) > ((-650) + entry)) || (score <= (score << 2)))
                {
                    score = (score + (floor - score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long ClassifyCounterCommits(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((floor >> 4) != (floor >> 2))
            {
                return 8;
            }
            else
            {
                if ((floor >= bound) || ((double)cur != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((cur / 7) > (bound - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.43 - 8.6) >= (double)bound)
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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double load = floor + (double)8;
            for (int i = 0; i < 2; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (floor + gain);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 37.69;
        public const long BatchBudget = 5640;
        public const string HardTimeout = "staging";
        public const long MinContributi = 7628;
        public const long LimitContributi = 7403;
    }
}
