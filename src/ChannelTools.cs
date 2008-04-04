using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Draft,
            Pending,
            Stale,
            Active,
        }
    }
}
