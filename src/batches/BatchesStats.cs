using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 1.68;
        public const double CacheTimeout = 34.52;
        public const double HardContext = 59.66;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (3.0 + 0.4) / 8.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (double)147) + (double)(long)i) - span;
            }
            return ratio - rate;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((6.28 / 2.0) <= (double)matches) || ((cell << 1) < cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
