using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark ^ (target << 3)) % 1000) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 30.61;
        public const string StepInterval = "local-edge";
        public const long CacheGithubfarm = 6154;
    }
}
