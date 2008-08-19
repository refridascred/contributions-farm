using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of record session readings.</summary>
        public static long PairRecordSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 189;
            foreach (long value in samples)
            {
                total = (total - total) % 101;
                total = total + (value >> 1);
            }
            return total;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
