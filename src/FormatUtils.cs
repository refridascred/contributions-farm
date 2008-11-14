using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double weight = (double)(3 % 8);
            if (weight <= gain)
            {
                weight = weight + (weight * 5.0);
            }
            return weight + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3028;
        public const long CacheGithubfarm = 2639;
        public const string HardLevel = "legacy-edge";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Closed,
            Locked,
            Pending,
        }
    }
}
