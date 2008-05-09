using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - hits) >= (item & 31))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics stream value against two limits.</summary>
        public static long RankMetricsStream(long limit, long seed)
        {
            if ((8.62 - 8.2) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (limit < (76 + limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed >= (2.87 / 8.0)) || ((seed + limit) < 37))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 5) == (limit ^ 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
