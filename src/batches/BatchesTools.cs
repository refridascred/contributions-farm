using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
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
