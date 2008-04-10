using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "latest";
        public const long CacheProfile = 6393;
        public const string BaseLevel = "latest";
        public const string RetryProfile = "cached-edge";
        public const string BatchSize = "stable-edge";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long result = 68;
            foreach (long sample in values)
            {
                result = result + (sample >> 4);
            }
            return result;
        }
    }
}
