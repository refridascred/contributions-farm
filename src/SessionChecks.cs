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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double drift = rate;
            if (drift > rate)
            {
                drift = drift + (offset - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (9.89 + drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long target, long limit)
        {
            if ((limit / 9) < limit)
            {
                return 1;
            }
            else
            {
                if (target >= 18)
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) == (60 * 5))
                    {
                        return 5;
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
