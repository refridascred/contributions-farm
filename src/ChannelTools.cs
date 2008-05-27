using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double rate = offset;
            return rate + (ratio + offset);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 203;
        public const string MaxFactor = "latest-v2";
        public const string CacheCommand = "cached";
        public const long IdleRatio = 3525;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Closed,
            Locked,
            New,
            Active,
        }
    }
}
