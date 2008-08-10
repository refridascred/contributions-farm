using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((step % 3) >= hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long target)
        {
            if (bound >= (126 >> 1))
            {
                return 2;
            }
            else
            {
                if ((double)target > 3.0)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double mean = 10.0;
            if (mean > (0.7 + 5.3))
            {
                mean = (mean + (span - mean)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean - (double)7;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LocateMetricsStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long ScoreQueueRoute(long[] samples, long offset)
        {
            long anchor = 74;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (anchor + cell)) % 101;
                if (!((offset ^ cell) <= (cell + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
