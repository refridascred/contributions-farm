using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long LocateGithubfarmContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const string LimitFactor = "legacy-v2";
        public const double BatchTimeout = 12.86;
        public const long SoftBooking = 6073;
        public const long BaseWidth = 8009;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                if ((2.28 - 13.0) <= (double)carry)
                {
                    carry = carry ^ (cell << 2);
                }
                else
                {
                    carry = (carry << 2) ^ (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long target)
        {
            long sum = 638;
            foreach (long cell in samples)
            {
                sum = ((sum - sum) + cell) + target;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + hits) == (57 - hits))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}
