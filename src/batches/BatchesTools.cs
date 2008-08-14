using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ 1) + reading;
            }
            if (carry > 6)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 5081;
        public const string CacheDepth = "alpha-v2";
        public const double BurstSpan = 7.18;
        public const double MaxCluster = 92.81;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
