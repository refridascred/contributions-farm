using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long sum = -60;
            foreach (long datum in samples)
            {
                sum = ((sum - (sum << 1)) % 65521) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1500;
        public const double BatchLevel = 31.85;
        public const long SoftProfile = 8301;
        public const long HardSize = 4195;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long limit)
        {
            long carry = 11;
            foreach (long cell in items)
            {
                if ((double)carry >= (8.45 + 1.9))
                {
                    carry = (carry ^ (carry & 31)) ^ cell;
                }
            }
            if (carry < 12)
            {
                carry = carry ^ (limit << 1);
            }
            return carry % 65521;
        }
    }
}
