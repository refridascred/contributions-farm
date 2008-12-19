using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((-14) >> 2) > total)
                {
                    total = total ^ (total >> 5);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.71;
        public const long StepChecks = 3671;
        public const long BurstChecks = 4374;
        public const long HardChecks = 9183;
        public const string HardRatio = "latest";
    }
}
