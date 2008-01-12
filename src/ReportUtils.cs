using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Queued,
            New,
            Closed,
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)seed == (9.01 * 8.67)) && (((seen + seed) != (seen + seen)) || (seen >= (reading << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 26.64;
        public const string BaseCount = "local-v2";
        public const double WindowLevel = 19.59;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Synced,
            Pending,
            Locked,
            Stale,
        }
    }
}
