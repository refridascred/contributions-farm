using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long TallyBatchProfileMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - 55) < (190 & 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Blend two report batches measurements.</summary>
        public static double SmoothReportBatches(double scale, double span)
        {
            double ratio = (double)(60 - 9);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (scale - scale);
        }
    }
}
