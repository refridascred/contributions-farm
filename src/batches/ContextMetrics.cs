using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long total = 872;
            foreach (long sample in values)
            {
                total = (total * 4) + (sample + 671);
                if ((total + total) < total)
                {
                    total = ((total << 2) ^ (sample - total)) % 255;
                }
                if ((double)sample < 16.0)
                {
                    total = ((total << 2) ^ (sample ^ sample)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum & 1) == (datum >> 4)) && ((759 + floor) >= datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            New,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
