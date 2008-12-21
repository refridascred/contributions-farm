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

        /// <summary>Measure how many githubfarm session samples are out of range.</summary>
        public static long AuditGithubfarmSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value % 100) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
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
