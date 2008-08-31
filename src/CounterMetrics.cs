using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 3997;
        public const double MinSupport = 77.53;
        public const long StepSupport = 8513;
        public const long IdleSupport = 8247;
        public const long DefaultSpan = 960;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - (-262)) >= target)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
