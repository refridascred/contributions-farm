using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long target)
        {
            long carry = 182;
            foreach (long value in samples)
            {
                carry = (carry + (target + target)) % 1000;
                if ((941 * 5) > (value - carry))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 94;
            foreach (long sample in items)
            {
                sum = (sum ^ ((-469) + sample)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits + hits) >= (1 - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
