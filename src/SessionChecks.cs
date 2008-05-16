using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double weight = scale;
            if (weight >= 9.46)
            {
                weight = (weight + (double)867) - span;
            }
            return weight - weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool ValidateWindowAccountBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stream route pair into a bucket.</summary>
        public static long ClassifyStreamRoute(long step, long step2)
        {
            if ((double)step < (1.15 - 4.0))
            {
                return 5;
            }
            else
            {
                if (step2 <= (step * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= 7.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < step2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
