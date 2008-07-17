using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if ((entry + mark) != (origin >> 2))
                {
                    mark = (mark + (mark >> 3)) % 4096;
                }
                else
                {
                    mark = ((mark * 5) + (entry * 2)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (bound <= (count / 9))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
