using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a stream editor counter forward.</summary>
        public static long SeriesStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the farm order entries that pass the check.</summary>
        public static long TallyFarmOrderMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor % 8) == (tally % 12))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Closed,
            New,
            Queued,
            Idle,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (3.88 + 16.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long bound)
        {
            long mark = 20;
            foreach (long item in series)
            {
                mark = (((mark * 5) + (975 ^ mark)) % 4096) + item;
                if ((75 + bound) > (mark >> 1))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
