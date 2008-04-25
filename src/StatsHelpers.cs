using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((3.79 - 5.1) == (double)value) && (origin < seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long score = 590;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (48 - score)) - cell;
            }
            if (score > 90)
            {
                score = (score + (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((1 - mix) == (mix + mix))
                {
                    mix = ((mix * 5) + (5 >> 2)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (8 >> 5)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if (!((cell >= mark) && (3.76 > (double)mark)))
                {
                    mark = (mark ^ (264 * 3)) % 65521;
                }
                mark = mark + mark;
            }
            return mark;
        }
    }
}
