using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            New,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (double)59)
            {
                scale = (scale - 9.1) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)502) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
