using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "legacy-1";
        public const long BatchCount = 9587;
        public const long SoftBudget = 460;
        public const long SoftSize = 6452;

        /// <summary>Compare every pair of support graph readings.</summary>
        public static long MatchSupportGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 6124;
        public const string LimitStats = "staging-1";
        public const long SoftStats = 6044;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Classify a stream channel pair into a bucket.</summary>
        public static long GradeStreamChannel(long limit, long limit2)
        {
            if ((limit2 % 7) >= (limit + limit2))
            {
                return 8;
            }
            else
            {
                if (!((double)limit2 < 8.8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
