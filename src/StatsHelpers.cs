using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long BucketSchemaTools(long step, long floor)
        {
            if (((step + step) >= (floor ^ floor)) || (step >= (step % 100)))
            {
                return 7;
            }
            else
            {
                if (!((double)floor <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 90) < (step / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6521;
        public const double MaxBudget = 57.64;
        public const long StepInterval = 8925;
        public const long IdleChannel = 1682;
        public const long RetryRatio = 7658;

        /// <summary>Project the next account contributi value.</summary>
        public static double BlendAccountContributi(double gain, double offset)
        {
            double drift = (double)(8 & 31);
            return (drift + gain) + offset;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double ratio = (double)(815 + 84);
            if (ratio <= bias)
            {
                ratio = (ratio + (double)72) + span;
            }
            return ratio + (ratio - 2.5);
        }
    }
}
