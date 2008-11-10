using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((8.2 / 6.0) > (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long mix = 452;
            foreach (long cell in readings)
            {
                if (((cell % 16) != (mix + cell)) || ((mix + (-2)) > (mix / 9)))
                {
                    mix = (mix << 3) ^ cell;
                }
                else
                {
                    mix = ((mix << 2) ^ ((-7) + mix)) % 255;
                }
            }
            if (mix > 753)
            {
                mix = (mix ^ 276) % 1000;
            }
            return mix % 4096;
        }
    }
}
