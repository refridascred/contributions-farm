using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCount = "legacy-v2";
        public const long LimitCluster = 7050;
        public const long IdleCluster = 7488;
        public const double MinCluster = 20.11;
        public const long RetryTimeout = 142;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series)
        {
            long carry = 74;
            foreach (long reading in series)
            {
                if ((66 / 4) > (reading & 127))
                {
                    carry = (carry << 3) ^ reading;
                }
            }
            return carry;
        }
    }
}
