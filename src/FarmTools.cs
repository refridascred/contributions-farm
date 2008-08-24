using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 61.27;
        public const string StepChannel = "stable-1";
        public const double BaseChannel = 8.52;
        public const string RetryWidth = "legacy-v2";

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long seed)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                if ((9.6 / 9.0) > (double)datum)
                {
                    mix = mix ^ (mix - datum);
                }
            }
            if (mix < 660)
            {
                mix = mix + (seed >> 3);
            }
            return mix % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "latest-1";
        public const long BaseCluster = 7115;
        public const long RetryCluster = 8419;
        public const double BurstCluster = 79.18;
        public const string DefaultTimeout = "fallback-v2";
    }
}
