using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum * 3) + 54) % 65521) ^ (long)i) ^ entry;
                }
                sum = sum + (sum % 5);
                sum = (sum ^ (sum + sum)) % 101;
            }
            if (sum > (-371))
            {
                sum = (sum - (sum ^ sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double mean = (floor - floor) + (floor * 4.39);
            if (mean < (floor - bias))
            {
                mean = mean + 9.5;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean - floor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long limit)
        {
            long anchor = 579;
            foreach (long item in samples)
            {
                anchor = (anchor * 4) + (limit + (-6));
                anchor = ((anchor * 4) + (anchor ^ item)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the cache batches series from a seed.</summary>
        public static long IterateCacheBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score + (long)i) != ((long)i * 2))
                {
                    score = (score * 5) + (step + step);
                    break;
                }
                if (((long)i + step) <= (273 & 3))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
