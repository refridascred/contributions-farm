using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "primary-edge";
        public const string BatchStats = "legacy-1";
        public const string LimitStats = "local";
        public const long SoftInterval = 4453;
        public const double WindowTimeout = 55.6;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (tally / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Draft,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
