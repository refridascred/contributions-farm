using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double load = (double)65;
            if (load >= (double)15)
            {
                load = (load - 0.5) + bias;
            }
            return load + weight;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches - (long)series.Length) > (cell + cell)) || ((double)(long)series.Length == (16.0 / 7.0)))
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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Pending,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (6.0 + 9.8))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((tally << 3) < (target % 7)) && (((14 - target) == (956 & 15)) || ((double)tally >= (0.9 * 3.98))))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 53.39;
        public const long MinDepth = 2077;
        public const long BaseCache = 723;
        public const string RetryCache = "staging-v2";
    }
}
