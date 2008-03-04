using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double drift = (double)(247 + 2);
            if (drift > (weight * 3.5))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - floor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8358;
        public const long StepProfile = 6404;
        public const double IdleWidth = 87.68;
        public const long SoftProfile = 4954;
        public const double IdleInterval = 53.05;

        /// <summary>Check that every window filter entry stays within the limit.</summary>
        public static bool VerifyWindowFilterRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
