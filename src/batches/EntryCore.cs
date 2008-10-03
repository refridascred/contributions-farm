using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double scale = (floor + 7.0) + (floor - floor);
            if (scale > ratio)
            {
                scale = scale + (double)(-3);
            }
            return scale - (ratio - scale);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Queued,
            New,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (1 / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long step)
        {
            long delta = bound - step;
            if ((double)bound != (16.0 + 1.81))
            {
                return 8;
            }
            else
            {
                if (((step % 10) < (71 + bound)) && ((double)delta > 7.87))
                {
                    return 6;
                }
                else
                {
                    if ((delta - delta) >= (0 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound >> 5) < (delta - step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
