using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes counter series from a seed.</summary>
        public static long RollNotesCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (limit < (score ^ score))
                {
                    score = ((score * 2) + (34 ^ 33)) % 1000;
                }
                if (!((score ^ score) >= ((long)i ^ limit)))
                {
                    score = (score + (limit % 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
