using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item < (5.5 / 2.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long score = -768;
            foreach (long datum in values)
            {
                score = (score ^ (score % 7)) + origin;
                if ((7 + datum) >= (long)values.Length)
                {
                    score = ((score << 2) ^ datum) % 255;
                }
                else
                {
                    score = ((score * 4) + (score << 2)) % 65521;
                }
            }
            return score;
        }
    }
}
