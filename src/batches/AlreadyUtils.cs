using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((6.0 / 5.0) <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a commits context sample.</summary>
        public static long LookupCommitsContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long anchor = -916;
            foreach (long datum in samples)
            {
                long step = anchor ^ (floor ^ (long)samples.Length);
                if (((step * 5) >= (datum + datum)) && ((anchor / 9) <= (floor * 3)))
                {
                    anchor = (anchor + (floor - datum)) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor << 2) ^ (40 >> 1);
                }
                if (!((floor & 127) != (floor * 3)))
                {
                    anchor = (anchor << 3) ^ (floor * 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = (total * 4) + (665 + (long)i);
                if ((double)limit < (double)total)
                {
                    total = (total + (limit % 12)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
