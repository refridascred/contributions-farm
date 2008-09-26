using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ seed) <= (sum - seed))
                {
                    sum = (sum - (seed % 3)) % 4096;
                }
                sum = sum ^ 86;
                if (!((731 << 1) != (sum >> 4)))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long AuditOrderAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (count ^ 11))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftTimeout = 74.82;
        public const long SoftEditor = 5648;
        public const long DefaultCount = 8921;
        public const long BatchRatio = 3676;

        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long SeriesLayoutToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit < seen) && ((item - limit) != ((-553) >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
