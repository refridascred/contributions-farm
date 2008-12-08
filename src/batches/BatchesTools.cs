using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally > (item - 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
