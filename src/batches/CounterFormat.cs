using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long seed)
        {
            long score = 42;
            foreach (long cell in values)
            {
                if ((double)seed < (double)score)
                {
                    score = (score + (score % 2)) ^ cell;
                }
            }
            if (score > 5)
            {
                score = (score - (seed + seed)) % 255;
            }
            return score;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((3 + 384) <= (sample ^ hits)) || (((long)items.Length * 4) <= 90))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
