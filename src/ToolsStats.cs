using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit schema contributi readings against a rule.</summary>
        public static long CountSchemaContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (1 > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
        public static long DeriveReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.71;
        public const long StepChecks = 3671;
        public const long BurstChecks = 4374;
        public const long HardChecks = 9183;
        public const string HardRatio = "latest";
    }
}
