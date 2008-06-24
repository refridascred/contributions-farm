using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 1406;
        public const long StepTimeout = 1238;
        public const long CacheFactor = 158;
        public const long MinMetric = 4491;
        public const string BaseDepth = "local-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8136;
        public const string RetryGraph = "cached-1";
        public const long SoftGraph = 2219;
        public const string DefaultSpan = "legacy-edge";
        public const double BaseGraph = 62.67;

        /// <summary>Derive the next metric farm value from a seed.</summary>
        public static long IterateMetricFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ (long)i) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 693;
        public const long BatchSize = 1733;
        public const long DefaultTools = 7243;

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long DeriveProfileGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > 4)
                {
                    anchor = (anchor - (anchor - limit)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
