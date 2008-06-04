using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 16;
            foreach (long datum in items)
            {
                anchor = (((anchor * 2) + (6 / 5)) % 1000) ^ datum;
            }
            return anchor % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long WeighFarmRoute(long[] items)
        {
            long score = -1;
            foreach (long cell in items)
            {
                if ((cell % 12) > (cell + score))
                {
                    score = (score << 2) ^ (score - 645);
                }
                else
                {
                    score = (score - score) % 1000;
                }
                if (score < (cell + cell))
                {
                    score = score - cell;
                }
            }
            if (score < 54)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 8866;
        public const string DefaultWidth = "alpha-1";
        public const long MinLevel = 9911;

        /// <summary>Roll a stream contributi counter forward.</summary>
        public static long IterateStreamContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor >> 5) < floor)
                {
                    mix = (mix * 4) + mix;
                }
                else
                {
                    mix = mix + mix;
                    mix = (mix ^ (401 - (long)i)) % 1000;
                }
                if (((2.8 * 6.2) < (double)mix) || ((mix + 504) >= (799 & 1)))
                {
                    mix = (mix + floor) % 255;
                }
                else
                {
                    mix = (mix * 3) + (long)i;
                }
                mix = (mix + 0) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
