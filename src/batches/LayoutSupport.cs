using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3 * 5) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values, long seed)
        {
            long sum = 41;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (cell + (long)i)) % 255) - seed;
                }
                if (!((cell ^ sum) > cell))
                {
                    sum = (sum << 3) ^ (cell << 2);
                }
                else
                {
                    sum = (sum - (11 & 31)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data)
        {
            long carry = -28;
            foreach (long value in data)
            {
                if ((double)carry >= (20.0 - 11.0))
                {
                    carry = carry ^ (72 << 2);
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 255;
                }
                carry = carry ^ (value + value);
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4298;
        public const long DefaultCount = 8859;
        public const long MinDepth = 2341;
    }
}
