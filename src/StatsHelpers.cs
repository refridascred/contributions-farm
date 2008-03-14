using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item < (6 << 3)) || ((hits >= (item >> 3)) && ((3.75 * 4.22) >= (double)item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 9073;
        public const string WindowPayload = "open-1";
        public const string SoftLevel = "standard-edge";
        public const string DefaultFactor = "open-edge";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }
    }
}
