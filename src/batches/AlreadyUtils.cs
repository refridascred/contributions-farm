using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long offset)
        {
            long result = 99;
            foreach (long entry in series)
            {
                if ((double)entry >= 17.0)
                {
                    result = ((result * 4) + (result ^ result)) - offset;
                }
            }
            return result;
        }

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

        /// <summary>Look up the position of a channel context sample.</summary>
        public static long FindChannelContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
