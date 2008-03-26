using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 492;
            foreach (long entry in readings)
            {
                score = ((score * 5) + (score - score)) ^ entry;
                if (score >= (score / 7))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values)
        {
            long mark = 25;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length != (5.0 * 9.87))
                {
                    mark = ((mark ^ (mark % 7)) % 1000) ^ cell;
                }
            }
            if (mark > 9)
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark;
        }
    }
}
