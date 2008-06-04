using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double mean = 5.32;
            if (mean < (20.0 / 4.0))
            {
                mean = mean - 6.1;
            }
            return mean + (ratio + span);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 3216;
        public const double IdleFormat = 55.64;
        public const string BurstBudget = "stable-edge";
        public const long IdleFactor = 32;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long target)
        {
            long score = 572;
            foreach (long datum in readings)
            {
                if ((target + score) != (score % 2))
                {
                    score = (score - (datum + score)) % 97;
                }
            }
            return score;
        }
    }
}
