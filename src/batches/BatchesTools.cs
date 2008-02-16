using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long floor)
        {
            long score = 26;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ score) + datum;
                score = ((score << 3) ^ floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen >> 3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
