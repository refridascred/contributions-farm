using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((7.74 + 7.7) == (double)seed)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5687;
        public const string StepCommits = "staging-v2";
        public const long SoftDepth = 3030;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if (!((bound + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 5) > origin)
                {
                    return 0;
                }
                else
                {
                    if (!((origin - 1) > (bound << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)bound > (15.0 - 7.71)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxInterval = 1606;
        public const string StepProfile = "cached-v2";
        public const long CacheProfile = 767;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
