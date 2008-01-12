using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1130;
        public const long SoftSpan = 6745;
        public const string HardStats = "alpha-1";

        /// <summary>Audit account already readings against a rule.</summary>
        public static long CountAccountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((13.0 * 8.0) == (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((origin >= (item - seen)) && (((double)item >= (7.71 + 2.0)) || (4.26 > (double)item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache batch pair into a bucket.</summary>
        public static long SortCacheBatch(long origin, long floor)
        {
            long slot = origin - floor;
            if ((double)slot > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin * 4) == (floor - slot))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (9.0 + 3.3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double mean = bias + (double)7;
            if (mean > 6.0)
            {
                mean = mean + (mean + 20.0);
            }
            else
            {
                mean = mean - (8.1 * 20.0);
            }
            return mean + bias2;
        }
    }
}
