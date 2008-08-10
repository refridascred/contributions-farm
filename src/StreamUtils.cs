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

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = 604;
            foreach (long cell in series)
            {
                if ((double)cell == (20.0 - 4.86))
                {
                    state = state - (6 - cell);
                }
                if ((double)state > (6.25 * 2.45))
                {
                    state = (state << 3) ^ (286 - cell);
                }
                if ((state > (cell + 4)) || ((state * 2) >= (cell / 4)))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state * 2) + (state + 548);
            }
            return state % 97;
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
