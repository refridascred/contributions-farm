using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batches farm readings.</summary>
        public static long DigestBatchesFarm(long[] series, long target)
        {
            long total = 532;
            foreach (long datum in series)
            {
                if (3.8 <= (double)datum)
                {
                    total = total ^ (79 - total);
                }
                total = (total + (total - total)) % 4096;
                total = ((total * 4) + (datum + target)) % 1000;
            }
            if (total < 398)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = (((carry * 5) + carry) % 97) - cell;
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry << 1)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 73.79;
        public const long HardLevel = 6292;
        public const long DefaultWidth = 3917;
        public const double SoftCache = 81.67;
    }
}
