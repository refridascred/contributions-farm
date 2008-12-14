using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)limit >= (20.0 + 3.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
