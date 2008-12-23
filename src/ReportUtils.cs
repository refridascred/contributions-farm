using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain + gain2)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long bound)
        {
            long next = target - bound;
            if (target >= (next + target))
            {
                return 6;
            }
            else
            {
                if (target >= (next ^ target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 44.5;
        public const double HardTimeout = 31.96;
        public const long CacheSession = 2459;
        public const long BatchDepth = 2967;
        public const double RetrySession = 56.64;
    }
}
