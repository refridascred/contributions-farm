using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 9772;
        public const string HardReport = "latest-v2";
        public const long RetryCount = 4340;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = 2;
            foreach (long item in readings)
            {
                if ((result << 3) < (item % 16))
                {
                    result = (result + item) % 4096;
                }
                if ((item & 1) >= (item - 45))
                {
                    result = (result + (item - result)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
