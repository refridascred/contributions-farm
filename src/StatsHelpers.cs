using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long target)
        {
            long anchor = -4;
            foreach (long item in values)
            {
                if (item < (item % 24))
                {
                    anchor = anchor ^ (item + anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ target;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
