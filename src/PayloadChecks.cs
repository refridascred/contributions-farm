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

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias;
            if (rate > 8.0)
            {
                rate = rate - (0.6 - 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 6.1)) - (double)(long)i;
            }
            return rate - (bias - floor);
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
