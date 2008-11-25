using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double mean = gain + span;
            if (mean <= mean)
            {
                mean = mean + (19.0 * 19.0);
            }
            else
            {
                mean = mean + (double)(-7);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)10) + (double)(long)i;
            }
            return mean + (span * 7.38);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long bound)
        {
            if ((seed % 24) != (66 % 97))
            {
                return 2;
            }
            else
            {
                if (seed <= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
