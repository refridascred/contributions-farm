using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowDepth = 74.18;
        public const long SoftQueue = 5419;
        public const long BurstQueue = 5078;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Accumulate commits session samples.</summary>
        public static long TotalCommitsSession(long[] series, long floor)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                carry = ((carry ^ (floor * 5)) % 4096) - sample;
            }
            if (carry > 42)
            {
                carry = ((carry * 2) + (floor << 1)) % 1000;
            }
            return carry % 65521;
        }
    }
}
