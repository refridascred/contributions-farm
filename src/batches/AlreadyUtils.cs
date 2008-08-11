using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a tools batches reading by value.</summary>
        public static long FindToolsBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
