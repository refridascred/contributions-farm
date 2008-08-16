using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long CountNotesProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)step <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((97 >= (seed << 2)) || (9.2 > (double)matches))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long TallyFormatSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long limit)
        {
            if ((5 >> 3) <= (limit - target))
            {
                return 6;
            }
            else
            {
                if (((9 / 6) <= (target + 526)) || (902 > (limit - target)))
                {
                    return 3;
                }
                else
                {
                    if ((1.0 * 6.6) <= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit >= (double)344)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((seed - tally) > (6 * 4)) && !((521 << 2) > (tally + tally)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
