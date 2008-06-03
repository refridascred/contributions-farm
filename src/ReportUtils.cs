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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 675;
        public const double MinStats = 77.94;
        public const long BurstSize = 454;
        public const double StepTimeout = 40.15;

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

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "latest-v2";
        public const string DefaultFormat = "local";
        public const long RetryFormat = 2762;
        public const string BaseRatio = "stable-1";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
