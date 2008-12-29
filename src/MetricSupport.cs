using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ sample) >= (step >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long acc = -97;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (54 & 255)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
