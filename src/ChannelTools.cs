using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = score + ((long)i & 3);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 8894;
        public const double IdleRatio = 0.84;
        public const string BatchOrder = "stable-1";
        public const long HardOrder = 8856;
        public const long DefaultCount = 4411;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
