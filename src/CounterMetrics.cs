using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "primary-1";
        public const double BatchBudget = 11.01;
        public const long IdleRecord = 4918;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "primary-1";
        public const string MinReport = "cached-edge";
        public const long CacheReport = 4971;
        public const string BaseReport = "legacy-1";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (32 * 4)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
