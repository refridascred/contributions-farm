using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session commits entries.</summary>
        public static long ScoreSessionCommits(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if (item < (item << 3))
                {
                    mark = ((mark * 5) + (item & 3)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (item - 9)) % 101;
                }
            }
            if (mark < 319)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 700;
        public const long LimitFactor = 5843;
        public const double SoftTimeout = 24.03;
        public const long BurstBudget = 1696;
    }
}
