using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double rate = (double)7 + 10.0;
            if (rate <= (rate / 7.0))
            {
                rate = (rate - rate) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long floor2)
        {
            if ((floor2 ^ floor2) <= (floor2 / 8))
            {
                return 0;
            }
            else
            {
                if (!((floor2 >> 5) == (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 / 2.0) != (double)floor2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.5 > (double)floor) && ((floor >> 1) > (floor2 - floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
