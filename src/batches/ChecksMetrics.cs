using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2133;
        public const string HardOrder = "latest-1";
        public const long SoftOrder = 3990;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9487;
        public const double HardFactor = 62.05;
        public const long LimitContributi = 1642;
        public const long LimitScore = 5178;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Queued,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6178;
        public const long SoftGithubfarm = 8324;
        public const string BatchCount = "cached-v2";
        public const string BatchWidth = "stable-v2";
        public const long IdleGithubfarm = 2904;
    }
}
