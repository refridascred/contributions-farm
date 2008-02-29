using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long IterateOrderAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - origin) <= (carry % 16))
                {
                    carry = (carry << 2) ^ origin;
                    carry = (carry ^ (origin >> 5)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)limit < (double)0)
                {
                    result = result ^ (long)i;
                }
                else
                {
                    result = result + (655 + (long)i);
                }
                result = ((result << 3) ^ result) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long acc = 24;
            foreach (long item in series)
            {
                if (item > (bound << 1))
                {
                    acc = (acc + (item & 255)) % 4096;
                }
                else
                {
                    acc = ((acc * 2) + (bound - bound)) % 255;
                }
            }
            if (acc > 414)
            {
                acc = ((acc << 2) ^ (4 ^ bound)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
