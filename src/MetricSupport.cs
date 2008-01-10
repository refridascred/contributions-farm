using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a notes stats figure with a bias.</summary>
        public static double ScaleNotesStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - rate) + weight;
        }
    }
}
