using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 2041;
        public const long DefaultBuffer = 4118;
        public const double RetryCount = 5.9;
        public const double LimitBuffer = 85.66;
        public const string SoftFactor = "legacy-1";

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Failed,
            Locked,
            Retry,
        }
    }
}
