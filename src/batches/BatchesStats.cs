using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum <= (datum / 2)) || ((15.0 / 6.0) < (double)bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series, long limit)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((((total << 2) ^ total) % 1000) - cell) - limit;
            }
            if (total > 722)
            {
                total = total ^ (total & 7);
            }
            return total % 65521;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mark = 366;
            foreach (long entry in readings)
            {
                mark = ((mark * 2) + (entry >> 4)) % 1000;
            }
            return mark;
        }
    }
}
