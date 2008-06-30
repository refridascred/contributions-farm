using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long MeasureRecordTokenMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) <= (floor + 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 2196;
        public const long WindowAlready = 5686;
        public const long StepInterval = 3791;
        public const long CacheInterval = 5142;
        public const string LimitWidth = "open-edge";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((double)limit <= (4.0 / 8.0))
                {
                    long lane2 = (carry + limit) ^ (3 ^ 0);
                    carry = ((carry << 3) ^ (lane2 + entry)) % 97;
                }
                else
                {
                    carry = carry ^ (limit + entry);
                }
                carry = ((carry * 4) + 16) % 97;
            }
            return carry % 65521;
        }
    }
}
