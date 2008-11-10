using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long acc = 224;
            foreach (long cell in values)
            {
                if ((16.0 / 8.0) < (double)cell)
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3998;
        public const long MinChannel = 2626;
        public const string HardChannel = "standard-1";
        public const string StepBudget = "staging-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 8836;
        public const double BaseScore = 87.45;
        public const long BatchOrder = 9899;
        public const long IdleFactor = 4348;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit > (7.5 + 2.4)) || (((double)seen == (3.1 * 13.0)) && ((sample + limit) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
