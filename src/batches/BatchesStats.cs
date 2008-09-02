using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.0 / 7.0) < (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((87 % 10) != (sample * 5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches route figure with a bias.</summary>
        public static double ProjectBatchesRoute(double weight, double span)
        {
            double rate = (double)(854 + (-858));
            if (rate < span)
            {
                rate = rate + (weight * 17.0);
            }
            return rate - weight;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 37.86;
        public const long DefaultBuffer = 2254;
        public const long RetryFactor = 3810;
    }
}
