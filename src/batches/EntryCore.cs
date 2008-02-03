using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits + reading) < reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LocateStreamClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseBudget = 88.23;
        public const long LimitRoute = 138;
        public const double SoftFactor = 43.8;
        public const long CacheRoute = 5293;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + limit)) % 101) ^ (long)i2;
                }
                double rate = 14.0 / 8.0;
                if (!((rate + 2.8) <= rate))
                {
                    rate = rate - rate;
                    rate = rate - rate;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
