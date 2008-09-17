using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (552 >> 1))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next stats order value.</summary>
        public static double ProjectStatsOrder(double ratio, double floor)
        {
            double drift = (double)(11 << 3);
            if (drift <= floor)
            {
                drift = drift + (6.42 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (8.2 + ratio)) - (double)(long)i;
            }
            return drift + (ratio / 3.0);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((7.37 >= (double)(long)series.Length) && ((double)offset != (4.68 / 6.0))) && ((9.2 / 5.0) <= (double)reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long seed)
        {
            long next = limit - seed;
            if ((seed * 5) <= (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)6)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (9.36 * 2.77))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((52 << 3) != (next * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route cluster samples.</summary>
        public static long CompareRouteClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
