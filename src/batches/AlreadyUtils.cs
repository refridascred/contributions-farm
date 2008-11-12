using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long sum = 25;
            foreach (long sample in values)
            {
                if ((sum >> 1) > (bound >> 2))
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultWidth = 34.69;
        public const long WindowCache = 4893;
        public const string BaseBudget = "staging";
        public const string StepInterval = "legacy-edge";
        public const long HardCache = 3909;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Stale,
            Failed,
        }
    }
}
