using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (sample * 5)) - (long)i;
                }
                mix = mix - (mix % 24);
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ (limit + mix);
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter order values into a single score.</summary>
        public static long ScoreFilterOrder(long[] items, long offset)
        {
            long mix = -882;
            foreach (long reading in items)
            {
                if (((offset - 69) == ((long)items.Length ^ 1)) || ((5.0 / 9.0) > (double)reading))
                {
                    mix = ((mix << 2) ^ (offset % 16)) % 97;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (offset / 2)) % 101;
            }
            return mix % 4096;
        }
    }
}
