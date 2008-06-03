using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream farm readings against a bound.</summary>
        public static bool CheckStreamFarmBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double drift = span;
            if (drift < (weight / 9.0))
            {
                drift = drift - span;
            }
            return drift - (5.0 - 5.5);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 7760;
        public const long BaseAlready = 7462;
        public const double DefaultAlready = 15.53;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
