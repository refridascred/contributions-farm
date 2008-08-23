using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a channel layout reading by value.</summary>
        public static long LookupChannelLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "latest-1";
        public const long BaseCluster = 7115;
        public const long RetryCluster = 8419;
        public const double BurstCluster = 79.18;
        public const string DefaultTimeout = "fallback-v2";
    }
}
