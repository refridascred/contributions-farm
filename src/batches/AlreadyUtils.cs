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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            if ((-481) >= floor2)
            {
                return 4;
            }
            else
            {
                if ((floor * 4) != ((-729) >> 3))
                {
                    return 6;
                }
                else
                {
                    if (3.1 <= (double)floor2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor2 >> 3) >= (floor2 + floor2)) || ((double)floor > 7.8))
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
    }
}
