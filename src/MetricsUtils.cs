using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 437;
        public const long MinContributi = 5308;
        public const double BaseContributi = 50.31;
        public const double DefaultContributi = 3.64;
        public const long MinLevel = 6986;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            long lane = floor - offset;
            if ((13.0 + 6.61) < (double)lane)
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (8.79 + 6.49)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 31.73;
        public const long DefaultFilter = 1420;
        public const double StepFilter = 34.6;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Paused,
            Retry,
        }
    }
}
