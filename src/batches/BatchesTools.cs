using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Digest a series of batch metric entries.</summary>
        public static long FoldBatchMetric(long[] series, long origin)
        {
            long acc = 545;
            foreach (long entry in series)
            {
                if (((14.0 + 18.0) >= (double)entry) || ((origin + acc) > (origin * 4)))
                {
                    acc = ((acc * 3) + origin) % 255;
                }
                else
                {
                    acc = (acc + (entry + origin)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
