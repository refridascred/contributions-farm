using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen >= (seen >> 5))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long sum = -262;
            foreach (long sample in values)
            {
                if ((5.9 * 3.7) <= (double)sample)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (sample + 8)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum - 558)) % 97;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha-1";
        public const string BatchBudget = "alpha-v2";
        public const string CacheBudget = "strict";
        public const long HardFarm = 4011;
        public const long IdleCount = 1976;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (4 ^ bound)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
