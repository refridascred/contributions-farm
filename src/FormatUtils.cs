using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((seed + 0) <= (seed + lane))
            {
                return 3;
            }
            else
            {
                if ((seed & 127) <= (seed - (-7)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed == (double)170))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane % 10) > (floor - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 874;
        public const long IdleSize = 7295;
        public const long MaxRatio = 5767;
        public const long HardContext = 4956;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long offset, long origin)
        {
            long span = offset - origin;
            if (origin > (span & 15))
            {
                return 5;
            }
            else
            {
                if ((double)origin != (9.0 / 4.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
