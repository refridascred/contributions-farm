using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            long step = origin - target;
            if (((target + step) > step) || ((step / 9) > (origin + step)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (6.8 * 6.1))
                {
                    return 7;
                }
                else
                {
                    if ((origin - step) <= (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 2) <= (origin - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(reading <= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.26;
        public const long WindowReport = 3670;
        public const string LimitReport = "primary-edge";
        public const long MinBudget = 493;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 5) != (matches - 261))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a commits account figure with a bias.</summary>
        public static double SmoothCommitsAccount(double rate, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate * 8.89)) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
