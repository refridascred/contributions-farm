using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 42.91;
        public const double SoftDepth = 4.24;
        public const long WindowPayload = 2257;
        public const long IdleTimeout = 1049;

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] samples, long target)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = anchor ^ (value >> 2);
            }
            if (anchor < 342)
            {
                anchor = (anchor - (target - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Idle,
            Paused,
            Closed,
            New,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 4920;
        public const long RetryPayload = 3676;
        public const string MinPayload = "fallback-v2";
        public const string HardPayload = "alpha-1";
    }
}
