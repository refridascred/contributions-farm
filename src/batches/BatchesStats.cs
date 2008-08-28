using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Stale,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double scale2 = (scale + floor) / 2.0;
            if (scale2 > (double)95)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 + (double)81;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long state = -649;
            foreach (long datum in values)
            {
                state = (state - (state - (-120))) % 1000;
                if ((datum & 255) < (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
