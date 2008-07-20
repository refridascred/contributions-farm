using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (seed * 3)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit stream metrics readings against a rule.</summary>
        public static long AuditStreamMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((9 + 593) == ((long)items.Length - hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long TallyCommandCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) == (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings, long limit)
        {
            long state = 139;
            foreach (long datum in readings)
            {
                if ((double)limit == (8.4 - 9.75))
                {
                    state = ((state * 3) + (datum << 2)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state << 2)) % 97;
                }
                if (!((double)state >= (double)datum))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long MeasureOrderEntryHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (30 >= ((long)levels.Length >> 1))
                {
                    seen = ((seen + 3) ^ cell) + limit;
                }
            }
            return seen;
        }
    }
}
