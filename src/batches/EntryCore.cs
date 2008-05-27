using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long bound)
        {
            long mark = 92;
            foreach (long datum in series)
            {
                mark = (((mark << 2) ^ (datum / 4)) % 255) - bound;
            }
            return mark;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            if (((step & 15) > floor) || (step < (step + floor)))
            {
                return 0;
            }
            else
            {
                if (step <= (381 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (18.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 5) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long mix = 29;
            foreach (long sample in levels)
            {
                mix = (mix + bound) + sample;
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (origin > (hits << 3))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
