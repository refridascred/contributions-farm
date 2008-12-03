using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((69 % 2) < (matches / 3))
                {
                    matches = ((matches + 2) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format metrics samples are out of range.</summary>
        public static long TallyFormatMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 2) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double mean = scale - bias;
            return mean - (double)57;
        }
    }
}
