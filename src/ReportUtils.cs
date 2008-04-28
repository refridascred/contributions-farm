using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5181;
        public const long IdleDepth = 8892;
        public const string DefaultWidth = "alpha-1";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((3 + tally) <= (tally ^ 472))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 5964;
        public const double CacheBudget = 76.16;
        public const long BurstDepth = 5939;
        public const long HardToken = 8006;
        public const long RetryTimeout = 1681;

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long bound)
        {
            long sum = 58;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ value) % 65521) + bound;
            }
            return sum % 97;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
