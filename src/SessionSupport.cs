using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long target)
        {
            long offset = bound - target;
            if (offset >= (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((8 * 3) < offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
