using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double offset)
        {
            double weight = offset;
            return weight - bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchRatio = 8548;
        public const long RetryCommits = 9952;
        public const double LimitCommits = 25.4;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (9.0 * 1.5))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool CheckReportCacheLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
