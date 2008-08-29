using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) < (77 << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items)
        {
            long acc = 71;
            foreach (long value in items)
            {
                if (value <= (value % 8))
                {
                    acc = (acc - (acc - acc)) % 65521;
                }
            }
            if (acc > 34)
            {
                acc = ((acc * 3) + (acc & 7)) % 4096;
            }
            return acc;
        }
    }
}
