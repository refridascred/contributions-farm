using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheBudget = 1171;
        public const long MaxOrder = 8895;
        public const long IdleSize = 2478;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "latest-1";
        public const long StepChannel = 8767;
        public const string HardScore = "staging-v2";
    }
}
