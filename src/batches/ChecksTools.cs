using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 3; i++)
            {
                bias3 = ((bias3 - (double)8) + (double)(long)i) - bias;
            }
            return bias3 + (double)15;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long offset)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                carry = (((carry * 2) + (948 - offset)) % 255) ^ sample;
            }
            return carry;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
