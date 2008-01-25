using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the counter cache entries that pass the check.</summary>
        public static long TallyCounterCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((6.07 / 4.0) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long mark = 38;
            foreach (long sample in readings)
            {
                if (sample < ((long)readings.Length + sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + mark) % 65521;
                    mark = mark - ((long)i & 1);
                }
                mark = (mark * 5) + (sample + 90);
            }
            return mark % 1000;
        }

        /// <summary>Derive the next cluster support value from a seed.</summary>
        public static long DeriveClusterSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((bound * 2) > 45)
                {
                    anchor = (anchor ^ (bound * 3)) % 1000;
                    anchor = anchor - (bound * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
