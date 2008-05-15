using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double offset)
        {
            double weight = offset * 9.3;
            return (weight - weight) + scale;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 5210;
        public const long DefaultLevel = 4868;
        public const string BatchLevel = "latest-edge";
        public const double StepGithubfarm = 40.27;
        public const long RetryWidth = 165;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2610;
        public const double BaseBudget = 2.14;
        public const long HardCommand = 9904;
        public const string StepTimeout = "primary-1";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Locked,
            Retry,
            Failed,
        }
    }
}
