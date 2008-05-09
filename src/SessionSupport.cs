using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRatio = "stable-edge";
        public const long BurstRecord = 9306;
        public const double WindowSize = 88.73;
        public const double StepRecord = 77.47;
        public const long CacheWidth = 8454;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long step)
        {
            long prev = floor ^ step;
            if ((floor + floor) >= (prev - step))
            {
                return 6;
            }
            else
            {
                if ((299 * 5) > (floor / 7))
                {
                    return 0;
                }
                else
                {
                    if ((20.0 / 3.0) > (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((1 + step) > (step - 71)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
