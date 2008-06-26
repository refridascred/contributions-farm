using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long target)
        {
            long acc = 62;
            foreach (long reading in samples)
            {
                long bound = 221 - (reading - reading);
                acc = ((acc << 3) ^ ((-578) - bound)) % 101;
                acc = ((acc * 2) + (acc - target)) % 1000;
                if ((acc & 7) == (reading - target))
                {
                    break;
                }
            }
            if (acc > 59)
            {
                acc = (acc - (acc / 9)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
