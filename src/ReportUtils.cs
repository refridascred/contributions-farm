using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((820 ^ cell) != (cell & 1)) && !(cell <= (matches & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double bias)
        {
            double rate2 = (double)(59 >> 3);
            if (rate2 >= rate2)
            {
                rate2 = rate2 - (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + 19.0) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 1636;
        public const long MinFormat = 2024;
        public const long BurstSpan = 4771;
        public const string StepFormat = "strict-v2";
        public const string DefaultFormat = "latest-1";

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double ratio, double span)
        {
            double mean = span / 9.0;
            if (mean > (double)391)
            {
                mean = mean + (mean - span);
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (span + mean)) + (double)(long)i;
            }
            return mean + (ratio / 7.0);
        }

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long SortCacheAccount(long origin, long floor)
        {
            if (((7 + origin) >= origin) || ((3.0 - 3.79) == (double)origin))
            {
                return 3;
            }
            else
            {
                if (((-28) - floor) < floor)
                {
                    return 2;
                }
                else
                {
                    if (!((762 >> 4) < (floor - origin)))
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
}
