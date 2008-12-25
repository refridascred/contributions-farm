using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Region { get; set; }
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Stale,
            Failed,
            Closed,
            Dropped,
        }
    }
}
