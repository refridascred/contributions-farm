using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 1853;
        public const long BurstSize = 4549;
        public const long MaxTools = 9712;
        public const double MaxBudget = 45.92;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Synced,
            Ready,
        }
    }
}
