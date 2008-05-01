using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches - entry) < (entry - matches)) || (matches < (entry + matches)))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "legacy-v2";
        public const string BaseTimeout = "alpha-edge";
        public const long LimitRatio = 7219;
    }
}
