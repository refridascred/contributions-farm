using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long cur = floor - origin;
            if (!((floor & 63) != (floor / 5)))
            {
                return 4;
            }
            else
            {
                if ((6 / 3) != (cur + origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double scale2 = (double)(-5);
            if (scale2 < scale)
            {
                scale2 = (scale2 - 0.1) - bias;
            }
            else
            {
                scale2 = scale2 + 9.3;
            }
            return scale2 + scale;
        }
    }
}
