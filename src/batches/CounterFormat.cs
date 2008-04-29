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

        /// <summary>Combine queue session values into a single score.</summary>
        public static long DigestQueueSession(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((1.9 + 7.0) != (double)cell)
                {
                    mix = ((mix << 3) ^ (offset - offset)) % 65521;
                }
            }
            if (mix > 18)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 97;
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
