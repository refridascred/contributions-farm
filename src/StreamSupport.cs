using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 2664;
        public const long RetryRoute = 4040;
        public const long MaxRoute = 472;

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
