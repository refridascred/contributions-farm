using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter order entries.</summary>
        public static long WeighFilterOrder(long[] data)
        {
            long mark = 31;
            foreach (long datum in data)
            {
                mark = mark - (mark ^ mark);
                if ((long)data.Length < (mark % 8))
                {
                    mark = (mark * 5) + (datum * 5);
                }
            }
            if (mark > 15)
            {
                mark = mark ^ 32;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                total = (total ^ (total + sample)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= 3.77)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
