using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)target <= 1.5)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((score > (score + target)) || ((long)i >= (target * 5)))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long state = 820;
            foreach (long datum in items)
            {
                if (!((datum % 5) > (datum * 5)))
                {
                    state = state - (datum % 12);
                    continue;
                }
                state = (state - (state >> 5)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
