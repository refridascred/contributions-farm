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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)target == (double)64) && !((target >> 3) < (target - datum)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
