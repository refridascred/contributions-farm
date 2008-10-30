using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((1.91 + 4.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Done,
            Active,
            Failed,
            Synced,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((double)offset < 12.0)
            {
                return 3;
            }
            else
            {
                if ((bound % 8) < 606)
                {
                    return 2;
                }
                else
                {
                    if ((225 >> 1) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "stable-1";
        public const double HardCache = 1.9;
        public const long RetryCache = 6514;
    }
}
