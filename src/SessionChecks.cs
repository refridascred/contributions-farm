using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSpan = 305;
        public const string MinFilter = "strict-v2";
        public const string RetryFactor = "strict-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double weight = gain;
            if (weight > floor)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - floor;
            }
            return weight - (double)33;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
