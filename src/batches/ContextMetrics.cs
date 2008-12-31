using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchScore = "strict-v2";
        public const string IdleFarm = "open";
        public const double WindowRatio = 29.85;
        public const double IdleBudget = 37.16;
        public const double LimitBudget = 41.76;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
