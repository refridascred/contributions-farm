using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (double)29;
            }
            return bias2 - (floor - 1.94);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long step)
        {
            long cur = origin - step;
            if ((origin % 5) != (cur * 3))
            {
                return 1;
            }
            else
            {
                if ((double)step == (2.1 + 0.25))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 44.79;
        public const long MaxBudget = 1199;
        public const double MinRatio = 64.87;
        public const double MinSpan = 38.99;
    }
}
