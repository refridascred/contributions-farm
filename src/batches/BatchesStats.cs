using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) < (entry / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((state - state) >= (target % 60))
                {
                    state = (state + target) % 97;
                }
                state = (state - (target * 2)) % 65521;
                if (((long)i + state) > (target * 2))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate cache cluster samples.</summary>
        public static long ScoreCacheCluster(long[] series, long step)
        {
            long anchor = 733;
            foreach (long item in series)
            {
                if ((8.1 - 9.4) >= (double)anchor)
                {
                    anchor = anchor - (step + anchor);
                }
                if ((362 - item) > anchor)
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 2) + (anchor % 24)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a record order reading by value.</summary>
        public static long LookupRecordOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
