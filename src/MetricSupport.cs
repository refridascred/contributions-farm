using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series, long bound)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                if (((double)sample != (double)bound) && ((bound & 7) >= (mark + mark)))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark + ((long)series.Length >> 1)) % 97;
                }
            }
            if (mark < 703)
            {
                mark = mark + (bound / 5);
            }
            return mark;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
