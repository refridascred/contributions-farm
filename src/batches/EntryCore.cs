using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 995;
        public const long DefaultContributi = 8343;
        public const long RetryContributi = 1973;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4498;
        public const long BatchBudget = 8884;
        public const string BatchRatio = "strict-1";
        public const long RetryMetric = 7076;
        public const long RetryFactor = 5211;

        /// <summary>Fold a list of batch layout readings.</summary>
        public static long DigestBatchLayout(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((anchor < (reading << 2)) || ((anchor & 31) > reading))
                {
                    anchor = anchor - (543 * 3);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (anchor + 2)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
