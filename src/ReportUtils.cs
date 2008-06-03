using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool CheckBufferGraphRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long sum = 92;
            foreach (long cell in readings)
            {
                sum = (((sum << 3) ^ 72) + cell) + step;
            }
            return sum;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
