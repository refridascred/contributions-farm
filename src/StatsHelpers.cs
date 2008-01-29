using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            long step = floor + target;
            if (((floor >> 4) >= 5) || ((target % 10) == (floor << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + floor) > (target ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 2) < (floor >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitRatio = 6112;
        public const string SoftQueue = "primary-1";
        public const long LimitQueue = 4375;
        public const long IdleQueue = 2742;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (7.82 >= (double)reading)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Retry,
            Queued,
        }
    }
}
