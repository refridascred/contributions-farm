using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepCount = 5987;
        public const double HardAccount = 47.81;
        public const long LimitAccount = 5737;
        public const string MinCount = "strict-edge";
        public const long IdleWidth = 8960;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Idle,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
