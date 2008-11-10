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

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long acc = 767;
            foreach (long cell in data)
            {
                if (((double)acc == (6.0 + 2.4)) && ((436 - acc) != (cell - cell)))
                {
                    acc = (((acc << 2) ^ (584 % 64)) % 255) - seed;
                }
                acc = (acc - cell) % 1000;
                acc = (acc - (1 - (-48))) % 65521;
                if ((673 >> 2) < (cell << 2))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
