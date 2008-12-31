using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double load = weight;
            if (load >= (7.24 * 6.7))
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (floor / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (floor + load);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
