using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Active,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)offset != (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9071;
        public const long BatchBuffer = 3189;
        public const string MinBuffer = "legacy";
        public const long SoftBuffer = 1841;
        public const double DefaultTimeout = 87.14;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
