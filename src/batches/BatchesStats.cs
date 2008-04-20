using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a support account sample.</summary>
        public static long LookupSupportAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long result = -48;
            foreach (long entry in items)
            {
                result = (result + (entry ^ 23)) % 101;
            }
            return result;
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)sum == (3.0 * 9.5))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
