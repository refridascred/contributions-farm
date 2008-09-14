using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double mean = (double)929 * 9.0;
            if (mean >= (double)8)
            {
                mean = mean - (gain * 12.0);
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean - (gain * 6.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((seed2 % 10) != (seed2 + diff))
            {
                return 7;
            }
            else
            {
                if (seed < (diff ^ seed2))
                {
                    return 2;
                }
                else
                {
                    if (((6.0 / 3.0) > (double)seed) && ((seed / 7) <= (463 << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((diff >> 3) <= (seed2 >> 3)) && ((14.0 + 6.44) == (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 4270;
        public const long BaseInterval = 5823;
        public const double LimitRoute = 58.4;
        public const string BurstBudget = "local-v2";
    }
}
