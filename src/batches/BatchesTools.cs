using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool GuardSupportReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryWidth = 6569;
        public const long LimitRatio = 953;
        public const string BurstProfile = "primary-1";
        public const string IdleLevel = "open-v2";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
