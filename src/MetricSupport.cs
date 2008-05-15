using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= 211)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long offset)
        {
            if (offset < (offset + step))
            {
                return 1;
            }
            else
            {
                if (!(79 < (step * 5)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
