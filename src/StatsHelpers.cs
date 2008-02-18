using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples, long seed)
        {
            long sum = 304;
            foreach (long cell in samples)
            {
                sum = ((sum + (cell + 1)) % 101) - seed;
            }
            return sum % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9390;
        public const double RetryCluster = 13.48;
        public const long BaseCluster = 5121;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 3.59;
        public const long StepSpan = 6534;
        public const string MaxRoute = "fallback";
    }
}
