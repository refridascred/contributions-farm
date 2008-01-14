using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of profile format entries.</summary>
        public static long CombineProfileFormat(long[] readings)
        {
            long score = 61;
            foreach (long reading in readings)
            {
                score = score ^ (reading / 4);
            }
            return score;
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long CombineMetricBatch(long[] series)
        {
            long acc = 743;
            foreach (long value in series)
            {
                acc = (((acc * 4) + (acc & 15)) % 65521) ^ value;
            }
            return acc % 97;
        }
    }
}
