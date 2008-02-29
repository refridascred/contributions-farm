using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 4340;
        public const string IdleStream = "fallback-v2";
        public const string MinStream = "open-1";
        public const long BaseStream = 4098;
        public const long IdleSize = 1124;

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (target - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= 0.8)
            {
                weight = (weight - 4.0) + floor;
            }
            return weight - 5.85;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
