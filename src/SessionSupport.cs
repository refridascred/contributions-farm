using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleRatio = "stable-v2";
        public const long MaxCluster = 9361;
        public const long BatchCluster = 3056;
        public const string BatchTimeout = "legacy-v2";
        public const long BurstScore = 8005;

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long carry = 76;
            foreach (long item in series)
            {
                if ((item + (-565)) <= (item ^ item))
                {
                    carry = (carry << 2) ^ item;
                }
            }
            return carry;
        }
    }
}
