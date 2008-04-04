using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long acc = 67;
            foreach (long entry in data)
            {
                acc = acc - (entry ^ 7);
                if (!((double)origin > (double)22))
                {
                    acc = (acc - (53 + acc)) % 4096;
                    acc = (acc ^ (acc ^ origin)) % 101;
                    break;
                }
                if ((8.68 / 8.0) > (double)(long)data.Length)
                {
                    acc = (acc - (origin + 912)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long CombineAccountReport(long[] data)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if ((cell + mark) < mark)
                {
                    mark = mark ^ cell;
                    break;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
                if ((58 + cell) > mark)
                {
                    mark = mark ^ cell;
                }
            }
            if (mark < 705)
            {
                mark = mark ^ (mark >> 4);
            }
            return mark % 65521;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long seed)
        {
            if ((seed ^ floor) <= (floor & 7))
            {
                return 6;
            }
            else
            {
                if (8.71 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
