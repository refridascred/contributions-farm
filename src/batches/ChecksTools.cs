using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepLevel = 5790;
        public const string DefaultSpan = "standard-1";
        public const long MaxGithubfarm = 3767;
        public const long LimitGithubfarm = 3056;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length == (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 148;
        public const string SoftChecks = "standard";
        public const long MinTimeout = 5721;
        public const long BurstSpan = 6867;
    }
}
