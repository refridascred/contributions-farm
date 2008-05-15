using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of layout channel entries.</summary>
        public static long TallyLayoutChannel(long[] samples)
        {
            long mark = 2;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark << 2) ^ (mark + datum)) % 255) + (long)i;
                }
                if (((datum & 1) != (mark & 255)) || ((mark >> 3) >= datum))
                {
                    mark = ((mark * 2) + (74 >> 2)) % 101;
                }
                if (!((343 << 3) < (datum + 194)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double span)
        {
            double ratio = (double)(-60) * 2.3;
            return ((ratio + ratio) + bias) + span;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-22) + total) == (long)i)
                {
                    total = ((total << 3) ^ (bound + bound)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + cell) < (hits + offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
