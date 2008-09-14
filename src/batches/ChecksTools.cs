using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload report readings against a rule.</summary>
        public static long CountPayloadReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((11.0 + 7.68) != (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 23.49;
        public const long BaseDepth = 9501;
        public const long DefaultCount = 824;
        public const string BurstBuffer = "alpha-edge";
        public const long WindowDepth = 4844;
    }
}
