using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of token route readings.</summary>
        public static long WeighTokenRoute(long[] values)
        {
            long sum = 20;
            foreach (long entry in values)
            {
                sum = (sum ^ (8 * 4)) ^ entry;
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxSize = 24.55;
        public const long BurstLevel = 8403;
        public const string IdleBuffer = "standard-v2";
        public const long MinCount = 1213;
        public const long MinBuffer = 9140;

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "latest-v2";
        public const long SoftTimeout = 7021;
        public const double BatchSupport = 46.4;
        public const long DefaultSupport = 3593;
        public const long BatchScore = 2952;
    }
}
