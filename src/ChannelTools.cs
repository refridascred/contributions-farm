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

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long value in samples)
            {
                acc = (acc ^ acc) ^ value;
            }
            if (acc < 69)
            {
                acc = (acc + seed) % 255;
            }
            return acc % 4096;
        }
    }
}
