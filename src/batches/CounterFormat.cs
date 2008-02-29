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
