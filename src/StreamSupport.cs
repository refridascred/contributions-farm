using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long TallyStreamAccountOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 7) == (entry + entry))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 28;
        public const long WindowSpan = 4259;
        public const string MaxStats = "standard-v2";
        public const long BurstStats = 855;
    }
}
