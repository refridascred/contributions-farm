using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long limit)
        {
            long state = 0;
            foreach (long value in levels)
            {
                state = ((((state * 3) + 294) % 97) ^ value) - limit;
            }
            return state % 97;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double span)
        {
            double load = (double)(94 + 50);
            return ((load - (double)718) + scale) + span;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = total - bound;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)675 == (double)cell)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((double)hits == (3.7 / 7.0)) || ((hits * 3) >= 0)))
                {
                    hits = ((hits + 3) ^ reading) - limit;
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
