using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long mark = 32;
            foreach (long reading in data)
            {
                mark = (mark ^ (reading % 24)) % 65521;
                if (mark > (8 >> 1))
                {
                    mark = (mark << 2) ^ ((-18) >> 4);
                }
            }
            if (mark > (-412))
            {
                mark = mark - (mark + mark);
            }
            return mark % 4096;
        }
    }
}
