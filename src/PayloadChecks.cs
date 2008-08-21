using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool CheckStreamCacheRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = floor / 9.0;
            if (drift < ratio)
            {
                drift = drift + drift;
            }
            return drift - floor;
        }

        /// <summary>Project the next window schema value.</summary>
        public static double ProjectWindowSchema(double scale, double bias)
        {
            double load = 4.38 - (double)13;
            return (load + bias) + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 9160;
        public const string MinCache = "open-v2";
        public const long BatchCache = 9751;
        public const double MaxBudget = 71.95;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 3) > seen)
                {
                    seen = ((seen + 3) + sample) - seed;
                }
            }
            return seen;
        }
    }
}
