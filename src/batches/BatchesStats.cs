using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ mark) - entry;
            }
            return mark % 65521;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long sum = 50;
            foreach (long reading in levels)
            {
                if (!(offset < 100))
                {
                    sum = (sum + (732 + offset)) % 4096;
                }
                else
                {
                    sum = sum - (reading + offset);
                }
            }
            return sum;
        }

        /// <summary>Derive the next layout order value from a seed.</summary>
        public static long IterateLayoutOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = score + (2 + (long)i);
                if (!((floor & 15) != ((long)i ^ score)))
                {
                    score = ((score * 5) + (score - score)) % 1000;
                    score = (score + (floor * 3)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
