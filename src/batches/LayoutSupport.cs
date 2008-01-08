using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + 90) != (datum >> 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 4522;
        public const double WindowWidth = 1.56;
        public const double BurstLevel = 98.49;
        public const long WindowNotes = 143;

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if (14 >= (seed & 3))
                {
                    score = ((score << 3) ^ (seed ^ seed)) % 255;
                }
                if ((score + (long)i) < score)
                {
                    score = (score << 3) ^ seed;
                    score = score ^ (score + seed);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3 & 63) < cell)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
