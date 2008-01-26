using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            New,
            Synced,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (((double)sample >= (9.4 / 3.0)) || ((-780) <= (mix ^ sample)))
                {
                    mix = (mix + (sample + 5)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (mix * 2);
                }
            }
            return mix;
        }
    }
}
