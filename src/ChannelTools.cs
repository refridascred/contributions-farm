using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxTimeout = 50.38;
        public const long LimitLayout = 2162;
        public const long SoftLayout = 1121;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
