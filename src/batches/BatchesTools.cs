using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + seed) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ (mark ^ mark)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate notes order samples.</summary>
        public static long TotalNotesOrder(long[] levels, long target)
        {
            long sum = 58;
            foreach (long datum in levels)
            {
                if (63 > (datum - datum))
                {
                    sum = ((sum * 2) + ((-3) + (long)levels.Length)) + target;
                }
                else
                {
                    sum = sum ^ (sum >> 5);
                }
            }
            if (sum < 50)
            {
                sum = ((sum * 4) + (sum % 3)) % 97;
            }
            return sum;
        }
    }
}
