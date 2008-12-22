using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long target2)
        {
            long next = target + target2;
            if (target2 > (target << 3))
            {
                return 1;
            }
            else
            {
                if ((15.0 * 0.7) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!((next >> 2) < (target2 + target2)))
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

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double mean = rate;
            if (mean <= (span / 9.0))
            {
                mean = mean - (double)74;
            }
            else
            {
                mean = mean + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (8.3 / 2.0)) - (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((2.51 + 2.0) <= (double)value) && ((long)levels.Length >= 582)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
