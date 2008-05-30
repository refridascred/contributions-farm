using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4 % 8) >= count) || ((target >> 4) == (target / 8)))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
