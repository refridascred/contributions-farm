using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double load = (double)(4 >> 5);
            if (load < 8.2)
            {
                load = (load + (double)94) + floor;
            }
            else
            {
                load = load - ratio;
            }
            return load + 10.0;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
