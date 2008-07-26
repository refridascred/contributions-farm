using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinCount = 6675;
        public const string DefaultQueue = "fallback-v2";
        public const double WindowQueue = 41.69;
        public const long MinInterval = 7586;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Grade a githubfarm notes value against two limits.</summary>
        public static long GradeGithubfarmNotes(long step, long bound)
        {
            if ((step << 3) <= (step + step))
            {
                return 7;
            }
            else
            {
                if ((bound * 4) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.56 / 3.0) != (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Closed,
            Stale,
            Failed,
        }
    }
}
