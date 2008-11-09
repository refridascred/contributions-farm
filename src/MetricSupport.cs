using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count command metric pairs that satisfy a relation.</summary>
        public static long PairCommandMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the buffer profile series from a seed.</summary>
        public static long RollBufferProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + ((long)i & 255);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
