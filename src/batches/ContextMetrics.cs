using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit graph counter readings against a rule.</summary>
        public static long TallyGraphCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches == (1.7 - 1.92))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long bound)
        {
            long carry = 46;
            foreach (long value in samples)
            {
                if ((8 + value) == (carry + carry))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    carry = carry - (195 + value);
                }
            }
            if (carry < 97)
            {
                carry = (carry + (carry + bound)) % 101;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Fold a list of report account readings.</summary>
        public static long TallyReportAccount(long[] values)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if (!(score <= (score + score)))
                {
                    score = (score << 3) ^ (score << 1);
                }
                score = (score ^ (reading + reading)) % 4096;
            }
            return score % 4096;
        }
    }
}
