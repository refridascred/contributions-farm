using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 72.29;
        public const long DefaultTimeout = 7925;
        public const double BurstCount = 34.61;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 511;
            foreach (long value in items)
            {
                state = (state ^ state) % 97;
                if ((double)value > 7.5)
                {
                    state = (state * 5) + (8 >> 3);
                }
                else
                {
                    state = ((state * 3) + (443 & 63)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
