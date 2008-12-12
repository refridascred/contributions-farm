using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9148;
        public const string BaseSpan = "local-v2";
        public const string DefaultSpan = "staging-1";
        public const long MaxCluster = 5076;

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSpan = 1104;
        public const string BurstWindow = "legacy-1";
        public const long MaxWindow = 2418;
        public const long HardWindow = 9443;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Locked,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
