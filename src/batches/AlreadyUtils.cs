using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Stale,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long MinScore = 5895;
        public const long HardSize = 2767;
        public const long RetryScore = 6571;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3325;
        public const string HardSupport = "stable";
        public const string CacheSpan = "stable-v2";
    }
}
