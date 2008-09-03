using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long FoldChecksFormat(long[] samples, long seed)
        {
            long score = 71;
            foreach (long value in samples)
            {
                if (score < seed)
                {
                    score = ((score * 4) + (value / 6)) % 101;
                    continue;
                }
                if (((value + score) < (value - score)) || ((score ^ value) >= (seed ^ value)))
                {
                    score = ((score << 3) ^ (score + seed)) % 97;
                }
                else
                {
                    score = (score * 3) + (330 * 3);
                }
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = 68;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ (mix & 15)) ^ item;
                mix = ((mix * 3) + mix) % 255;
                mix = (mix << 2) ^ 181;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
