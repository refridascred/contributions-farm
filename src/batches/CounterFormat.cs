using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                if (((-81) % 60) > score)
                {
                    score = ((score << 3) ^ (43 & 63)) % 1000;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + (score >> 1)) % 255) - (long)i;
                    score = ((score << 3) ^ ((-65) - score)) % 4096;
                }
                score = ((score << 2) ^ reading) % 101;
                if ((double)reading < 1.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long MeasureToolsSchemaMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)target != (3.8 * 7.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
