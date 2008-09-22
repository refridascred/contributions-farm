using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a contributi context reading.</summary>
        public static double ScaleContributiContext(double scale, double floor)
        {
            double rate = 14.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate - 2.0) + (double)(long)i) + scale) - floor;
            }
            return rate - (double)9;
        }

        /// <summary>Count queue report pairs that satisfy a relation.</summary>
        public static long OverlapQueueReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
