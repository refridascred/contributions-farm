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

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long step)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if ((cell + 62) >= (step & 15))
                {
                    mark = (mark << 2) ^ 37;
                }
                if ((cell >> 4) < ((long)series.Length + step))
                {
                    mark = (mark << 3) ^ step;
                }
                else
                {
                    mark = (mark << 3) ^ (step / 8);
                }
            }
            if (mark < 453)
            {
                mark = mark - step;
            }
            return mark;
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
