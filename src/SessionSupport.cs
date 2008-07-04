using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Closed,
            Draft,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 66.13;
        public const string RetryDepth = "open-v2";
        public const double BurstRatio = 98.15;
        public const long BaseBatch = 1420;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long floor)
        {
            long lane = step + floor;
            if ((floor - step) <= step)
            {
                return 4;
            }
            else
            {
                if ((lane & 255) > (floor >> 1))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
