using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8797;
        public const string WindowSpan = "open-v2";
        public const long LimitFactor = 8551;
        public const long WindowFactor = 493;
        public const long MaxScore = 2388;

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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((step >> 3) < seen) && ((reading >= step) || ((seen - seen) < (seen << 1))))
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
