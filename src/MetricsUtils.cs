using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Accumulate graph session samples.</summary>
        public static long TallyGraphSession(long[] levels, long step)
        {
            long mark = 684;
            foreach (long value in levels)
            {
                if (((6.0 + 2.8) >= (double)value) || (step >= (value & 1)))
                {
                    mark = (mark * 2) + (31 & 1);
                }
            }
            return mark;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long floor)
        {
            if (target <= (target % 24))
            {
                return 3;
            }
            else
            {
                if (target <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (9.2 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
