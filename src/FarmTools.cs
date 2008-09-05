using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading / 7) != (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (double)841)
            {
                mean = (mean - (double)80) - offset;
            }
            else
            {
                mean = mean + 8.9;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long seed)
        {
            long delta = origin + seed;
            if ((delta >> 5) <= origin)
            {
                return 6;
            }
            else
            {
                if ((double)delta > (7.74 - 15.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 31) == (7 - 992))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
