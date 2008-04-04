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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((count / 2) < (count + entry)) || ((9 >> 1) < (entry - entry)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
