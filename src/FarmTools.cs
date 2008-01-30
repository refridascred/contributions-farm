using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc + offset) % 4096) ^ (long)i2;
                }
                acc = ((acc * 2) + (offset + offset)) % 101;
                if ((acc - (long)i) != (offset % 5))
                {
                    acc = (acc << 3) ^ (offset + acc);
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                if ((15.0 + 8.0) >= (double)sample)
                {
                    score = ((score * 2) + (score - 35)) % 65521;
                }
                else
                {
                    score = score - (sample ^ score);
                }
            }
            return score;
        }
    }
}
