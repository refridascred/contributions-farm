using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSpan = 9184;
        public const long LimitRatio = 7027;
        public const long CacheGithubfarm = 9800;
        public const long SoftWidth = 4694;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 8970;
        public const string IdleBatch = "latest-edge";
        public const long MaxFactor = 2679;
        public const long CacheBatch = 5428;
        public const long BaseRatio = 519;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3833;
        public const string IdleWindow = "primary-v2";
        public const double IdleSpan = 36.19;
        public const long WindowBudget = 9131;
    }
}
