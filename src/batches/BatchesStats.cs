using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long AuditQueueClusterHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample <= ((long)items.Length >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 65521;
            }
            if (acc > 520)
            {
                acc = (acc ^ (acc / 9)) % 65521;
            }
            return acc;
        }
    }
}
