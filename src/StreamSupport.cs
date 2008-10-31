using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
