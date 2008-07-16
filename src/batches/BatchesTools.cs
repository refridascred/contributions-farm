using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long BucketMetricSupport(long offset, long limit)
        {
            if ((limit + 253) > (offset + limit))
            {
                return 4;
            }
            else
            {
                if (offset >= (limit + offset))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) >= (offset + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
