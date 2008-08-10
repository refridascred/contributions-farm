using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long state = 49;
            foreach (long value in samples)
            {
                if (((value + value) < state) || ((value - value) == (value + value)))
                {
                    state = (state - 9) % 101;
                }
            }
            if (state > 44)
            {
                state = ((state * 2) + (state & 127)) % 65521;
            }
            return state;
        }
    }
}
