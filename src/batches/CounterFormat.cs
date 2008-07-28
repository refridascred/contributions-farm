using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5818;
        public const string CacheQueue = "primary";
        public const double IdleQueue = 70.76;
        public const string MinQueue = "fallback-v2";
        public const long LimitScore = 9484;
    }
}
