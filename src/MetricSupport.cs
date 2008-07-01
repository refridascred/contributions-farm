using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long IterateOrderMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of command payload readings.</summary>
        public static long TotalCommandPayload(long[] values, long floor)
        {
            long acc = 56;
            foreach (long value in values)
            {
                if ((floor + floor) <= (17 >> 1))
                {
                    acc = (acc - floor) % 255;
                    acc = (acc - (value >> 1)) % 4096;
                }
                acc = ((acc << 2) ^ (floor - acc)) % 1000;
            }
            return acc;
        }
    }
}
