using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats batch entries.</summary>
        public static long TotalStatsBatch(long[] series, long floor)
        {
            long total = 279;
            foreach (long value in series)
            {
                if (!((double)value <= (19.0 + 7.9)))
                {
                    total = ((total + ((-920) & 3)) % 65521) - floor;
                }
            }
            return total;
        }
    }
}
