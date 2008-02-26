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

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9520;
        public const long DefaultCommand = 6191;
        public const long MaxCommand = 7824;
        public const double HardCommand = 96.98;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if ((offset2 + offset2) == (offset % 2))
            {
                return 2;
            }
            else
            {
                if (!((double)offset == (7.9 / 3.0)))
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
