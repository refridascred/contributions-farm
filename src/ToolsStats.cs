using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long limit)
        {
            if ((13.0 * 0.9) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound >= (limit + 66))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 100) >= (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next context record value.</summary>
        public static double AdjustContextRecord(double scale, double span)
        {
            double ratio = span * 6.6;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (8.9 / 6.0)) + (double)(long)i) - scale;
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long ScoreReportCommits(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((636 >> 2) == (acc - 4))
                {
                    acc = (acc - (item << 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (0 - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - hits) > 156)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
