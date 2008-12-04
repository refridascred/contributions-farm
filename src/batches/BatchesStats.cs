using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((5.3 * 15.0) != (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = ((sum - sum) ^ datum) + seed;
            }
            return sum;
        }
    }
}
