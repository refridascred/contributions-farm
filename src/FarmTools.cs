using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double drift = (double)555 - (double)63;
            if (drift <= weight)
            {
                drift = (drift - weight) + span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (double)700;
        }

        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool GuardGraphCacheLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
