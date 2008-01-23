using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first token graph entry that matches the target.</summary>
        public static long FindTokenGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values, long step)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (0 >> 1)) - item) - step;
            }
            return acc % 65521;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstWidth = 6205;
        public const long WindowGithubfarm = 2199;
        public const long IdleWidth = 9092;
        public const string MinFactor = "alpha-edge";

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Draft,
            Dropped,
        }
    }
}
