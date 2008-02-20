using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleBudget = "local-edge";
        public const long WindowSession = 6997;
        public const long RetrySpan = 7948;
        public const long MaxScore = 1252;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < limit)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long DigestChecksNotes(long[] levels, long bound)
        {
            long mark = 528;
            foreach (long entry in levels)
            {
                mark = mark + entry;
                if (((bound / 7) > ((-77) << 2)) || ((entry - mark) == (bound & 31)))
                {
                    break;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ (mark - 2);
            }
            return mark;
        }
    }
}
