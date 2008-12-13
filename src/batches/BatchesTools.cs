using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long bound)
        {
            long score = 8;
            foreach (long item in readings)
            {
                if ((score - bound) < bound)
                {
                    score = score + item;
                }
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric tools value from a seed.</summary>
        public static long StepMetricTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i >= (limit + (long)i)) || ((double)limit >= (1.5 + 8.2)))
                {
                    mix = (mix + (mix ^ limit)) % 97;
                    mix = ((mix * 4) + (mix + mix)) % 4096;
                }
                else
                {
                    mix = mix ^ ((long)i - limit);
                    mix = (mix ^ (0 % 7)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
