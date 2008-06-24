using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double load = (span - ratio) + (ratio * 3.0);
            return load - ratio;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Paused,
            Ready,
            Done,
            New,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5005;
        public const long BaseWindow = 8218;
        public const string BatchScore = "standard-edge";
        public const long LimitWindow = 8011;
        public const long BatchDepth = 9436;
    }
}
