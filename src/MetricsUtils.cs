using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Stale,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long CountEditorNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally >> 1) <= (tally + reading))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long origin)
        {
            long gap = bound - origin;
            if (((bound + bound) != (gap ^ gap)) || ((5.0 - 16.0) <= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((origin ^ 5) < (gap + 13)) || ((origin + origin) <= (gap + origin)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (bound + bound)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank layout metric input into a small class.</summary>
        public static long RankLayoutMetric(long floor, long limit)
        {
            long prev = floor - limit;
            if ((floor * 5) > prev)
            {
                return 3;
            }
            else
            {
                if ((prev / 4) != (prev - 94))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
