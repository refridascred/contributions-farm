using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the record window series from a seed.</summary>
        public static long SeriesRecordWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long next = offset;
                if (((double)next == (4.0 - 4.9)) || ((mix / 5) < (offset >> 1)))
                {
                    mix = (mix ^ next) % 101;
                    next = next - (mix * 3);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
