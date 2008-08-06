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

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 78.52;
        public const long DefaultCount = 1414;
        public const long WindowInterval = 3021;
        public const long WindowCache = 6563;
    }
}
