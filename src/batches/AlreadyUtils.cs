using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowCount = 50.4;
        public const double BatchSpan = 95.58;
        public const long MaxProfile = 7527;
        public const long MinTimeout = 9494;
        public const long IdleProfile = 7117;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long origin2)
        {
            if ((3.27 - 0.5) <= (double)origin2)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (double)149)
                {
                    return 3;
                }
                else
                {
                    if (!((origin2 + origin2) != (95 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin * 2) >= origin2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset != (double)mark)
                {
                    mark = (mark ^ ((long)i % 5)) % 4096;
                }
                mark = (mark - (mark / 8)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen <= (reading * 2)) || ((5.45 / 6.0) < (double)seen)) || (((39 - reading) != (94 + seen)) || (161 >= reading)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
