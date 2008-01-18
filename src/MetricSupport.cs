using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < (count >> 2))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
