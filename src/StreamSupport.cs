using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix + (mix + origin)) % 97) ^ (long)i2;
                }
                mix = mix ^ (mix << 3);
                if (8 > (mix >> 5))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                    mix = (mix * 3) + ((-956) - mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long origin)
        {
            if ((7.6 + 8.0) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit - 1) != (origin ^ limit))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen < (6 & 7))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
