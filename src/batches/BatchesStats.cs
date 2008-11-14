using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((5.07 * 0.94) <= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long acc = 99;
            foreach (long datum in series)
            {
                acc = (((acc + (57 % 2)) % 255) ^ datum) + offset;
            }
            return acc % 97;
        }
    }
}
