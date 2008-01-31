using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 5862;
        public const double BatchWidth = 18.7;
        public const double BatchGithubfarm = 8.24;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift <= scale)
            {
                drift = drift + (bias * 9.1);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
