using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor & 63) <= datum)
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

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool GuardFilterFormatRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long limit)
        {
            if ((3.8 - 12.0) == (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset < (limit & 31)) || ((double)limit > (double)132))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) > (offset - 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double mean = rate;
            if (mean <= offset)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)71) + (double)(long)i;
            }
            return mean + (double)41;
        }
    }
}
