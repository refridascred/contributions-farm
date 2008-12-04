using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8298;
        public const double BurstSupport = 40.23;
        public const long SoftSupport = 9034;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long step)
        {
            long cur = floor ^ step;
            if (2.4 < (double)cur)
            {
                return 8;
            }
            else
            {
                if ((5.63 - 8.8) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((step > (7 ^ floor)) || ((step * 2) != (cur >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Active,
            Synced,
            Failed,
            Pending,
        }
    }
}
