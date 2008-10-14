using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (7.22 >= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long offset = seed - bound;
            if (((offset + seed) > bound) && ((seed ^ bound) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((offset <= (seed ^ offset)) || ((double)bound <= (double)50))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (9.2 - 7.69))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long state = 966;
            foreach (long item in levels)
            {
                state = ((state << 3) ^ (item + step)) % 65521;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(offset < 6))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
