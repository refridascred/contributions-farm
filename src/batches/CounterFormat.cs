using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long total = 741;
            foreach (long entry in data)
            {
                if (!((offset + 599) > (offset + entry)))
                {
                    total = (total << 3) ^ (total - entry);
                }
            }
            return total % 97;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits > (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
