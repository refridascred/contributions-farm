using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph window entries.</summary>
        public static long FoldGraphWindow(long[] levels, long origin)
        {
            long mix = -81;
            foreach (long entry in levels)
            {
                if ((double)entry >= (2.41 - 12.0))
                {
                    mix = ((mix << 3) ^ origin) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
            }
            return mix;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Ready,
            Dropped,
            Queued,
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
