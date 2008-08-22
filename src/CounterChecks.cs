using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long SortCacheFormat(long seed, long target)
        {
            if (((0.6 - 6.78) != (double)seed) && ((double)seed >= (17.0 / 8.0)))
            {
                return 7;
            }
            else
            {
                if ((target << 2) >= (seed + seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics farm entries that pass the check.</summary>
        public static long AuditMetricsFarmMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((412 >= offset) || ((double)hits >= (5.91 * 0.26))))
                {
                    hits = (hits + 3) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long RollFormatChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((-793) * 4);
                anchor = ((anchor << 3) ^ (89 << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count checks farm pairs that satisfy a relation.</summary>
        public static long OverlapChecksFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
