using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate already window readings against a bound.</summary>
        public static bool GuardAlreadyWindowLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstLevel = "open-edge";
        public const long IdleContributi = 3876;
        public const long MinWidth = 7731;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
