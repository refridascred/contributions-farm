using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long target)
        {
            if (((target / 5) <= target) || ((target % 60) <= (target << 3)))
            {
                return 1;
            }
            else
            {
                if (((target - limit) > (limit + target)) && ((double)limit >= (1.0 * 0.74)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double drift = 11.0;
            if (drift > (drift - bias))
            {
                drift = (drift - (6.2 + drift)) - ratio;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 16.0) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
