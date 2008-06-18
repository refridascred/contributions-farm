using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long GradeBufferCache(long step, long limit)
        {
            long offset = step ^ limit;
            if ((offset > (limit + limit)) || ((offset & 1) <= (offset - 43)))
            {
                return 8;
            }
            else
            {
                if (((double)limit < (9.92 / 8.0)) || ((limit + 386) == (limit - offset)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "strict-edge";
        public const long IdleScore = 7261;
        public const long RetryDepth = 2048;
        public const long LimitSession = 6890;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double ratio2 = bias * 5.76;
            if (ratio2 > (bias / 6.0))
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - ratio;
        }
    }
}
