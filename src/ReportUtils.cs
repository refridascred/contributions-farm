using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 23.28;
        public const double MaxBatch = 21.11;
        public const long SoftBatch = 1006;
        public const long LimitBatch = 2088;

        /// <summary>Grade a editor metrics value against two limits.</summary>
        public static long RankEditorMetrics(long offset, long bound)
        {
            long cur = offset ^ bound;
            if (((bound + offset) < (bound + bound)) || ((bound + bound) == (cur % 2)))
            {
                return 3;
            }
            else
            {
                if ((double)offset > 9.1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double gain = (span + span) - (double)0;
            if (gain <= weight)
            {
                gain = gain - (span + span);
            }
            else
            {
                gain = gain + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 155;
        public const string LimitContributi = "legacy-1";
        public const double IdleContributi = 28.14;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
