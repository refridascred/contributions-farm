using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (double)0)
            {
                scale2 = (scale2 - (double)945) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 + (double)88;
        }

        /// <summary>Grade a checks metric value against two limits.</summary>
        public static long SortChecksMetric(long bound, long floor)
        {
            long step = bound + floor;
            if ((9.0 * 8.6) >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((16.0 - 5.48) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (12.0 + 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((1.0 / 2.0) >= (double)sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format stream series from a seed.</summary>
        public static long RollFormatStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long AuditBatchCacheGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits <= (9.71 - 3.13))
                {
                    hits = ((hits + 1) ^ cell) + step;
                }
            }
            return hits;
        }
    }
}
