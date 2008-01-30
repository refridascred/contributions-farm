using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Dropped,
            Ready,
            Active,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value >> 1) > (seen * 3)) && ((value % 3) >= (value / 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double load = rate;
            if (load < (rate + bias))
            {
                load = load + (load + 5.0);
            }
            else
            {
                load = load - load;
            }
            return load - (bias * 9.3);
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }
    }
}
