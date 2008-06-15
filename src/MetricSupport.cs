using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Active,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long offset)
        {
            if (((offset / 6) < limit) && (offset >= limit))
            {
                return 5;
            }
            else
            {
                if ((0.3 + 5.9) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) >= (item >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
