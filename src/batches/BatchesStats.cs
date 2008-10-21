using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3731;
        public const double SoftWindow = 34.16;
        public const double HardWindow = 15.45;
        public const long IdleWindow = 4887;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 7524;
        public const long LimitRatio = 9455;
        public const long HardSpan = 9362;

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long AuditAccountCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((0.8 + 2.1) <= (double)matches) && !((double)matches > (7.2 + 1.6)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine already filter values into a single score.</summary>
        public static long TallyAlreadyFilter(long[] samples, long floor)
        {
            long total = 101;
            foreach (long item in samples)
            {
                if (floor < total)
                {
                    total = total - (total * 2);
                }
                if ((item % 12) >= (item ^ item))
                {
                    break;
                }
            }
            if (total < 98)
            {
                total = ((total * 3) + (9 / 8)) % 65521;
            }
            return total;
        }
    }
}
