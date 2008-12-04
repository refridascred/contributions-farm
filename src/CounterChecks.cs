using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count != (8.6 - 8.0))
                {
                    count = ((count + 1) ^ value) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits > (double)(long)items.Length)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long seed)
        {
            long gap = offset - seed;
            if ((2.73 / 8.0) < (double)gap)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.0 + 5.01))
                {
                    return 4;
                }
                else
                {
                    if ((offset - seed) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap << 1) == (seed % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) == (datum + 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
