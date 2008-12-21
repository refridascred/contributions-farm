using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double gain2 = 8.82 + (gain * 7.71);
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + bias) + (double)(long)i;
            }
            return gain2 - 14.0;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double load = offset;
            return (load + offset) + ratio;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a notes profile reading.</summary>
        public static double ProjectNotesProfile(double bias, double floor)
        {
            double mean = bias / 8.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - floor;
            }
            return mean + 6.6;
        }
    }
}
