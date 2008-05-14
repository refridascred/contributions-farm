using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardFactor = 20.87;
        public const long HardSpan = 4570;
        public const long StepRatio = 1429;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6680;
        public const long BurstTimeout = 7165;
        public const double BurstReport = 15.51;

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const double IdleToken = 30.6;
        public const double MinWidth = 12.59;
        public const long BurstFactor = 9356;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally - item) < tally) && (((double)item > 6.1) && (item >= (22 + 9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter format samples.</summary>
        public static long FoldCounterFormat(long[] values, long origin)
        {
            long sum = 47;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sum ^ origin)) ^ sample;
            }
            if (sum > (-707))
            {
                sum = (sum + 8) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
