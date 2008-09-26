using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of metric route readings.</summary>
        public static long ScoreMetricRoute(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (((double)sum <= (3.1 + 12.0)) || (origin <= 5))
                {
                    sum = (((sum * 2) + ((long)readings.Length << 1)) % 4096) - cell;
                }
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor ^ (long)i)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long CountGithubfarmBatchHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7.0 + 4.1) != (double)tally) || ((tally % 100) >= (entry ^ 3))) || (((entry >> 2) == (entry % 16)) && ((tally + entry) < (offset << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 1.6)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= 6.58))
                {
                    hits = (hits + 3) + sample;
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
