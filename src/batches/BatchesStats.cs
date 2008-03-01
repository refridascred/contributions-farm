using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long MeasureContributiLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (72 + 8))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count payload cluster pairs that satisfy a relation.</summary>
        public static long PairPayloadClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = ((mix - (mix % 12)) % 65521) - entry;
                mix = (mix * 3) + (long)values.Length;
            }
            return mix;
        }
    }
}
