using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool VerifyCommandCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double SmoothRouteProfile(double gain, double floor)
        {
            double load = (double)(70 - 77);
            if (load >= floor)
            {
                load = (load + (load * 2.0)) - gain;
            }
            return load + load;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 3590;
        public const long StepSchema = 8905;
        public const string RetryFactor = "stable-edge";
        public const double LimitDepth = 14.78;
        public const long BurstRatio = 9750;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Paused,
            Dropped,
            Idle,
            Queued,
        }
    }
}
