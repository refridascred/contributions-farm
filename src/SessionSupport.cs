using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 2840;
        public const string HardProfile = "fallback-v2";
        public const long StepProfile = 9227;
        public const long DefaultRatio = 1852;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (0.48 - 7.7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) != (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
