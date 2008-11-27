using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 11.35;
        public const long DefaultRoute = 3622;
        public const string StepSpan = "staging-v2";
        public const double BatchSize = 47.57;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 8082;
        public const double BatchContributi = 52.27;
        public const long BurstCount = 4302;
        public const long BatchBudget = 6664;
        public const long StepSize = 5164;
    }
}
