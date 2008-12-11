using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two farm entry measurements.</summary>
        public static double ProjectFarmEntry(double gain, double span)
        {
            double ratio = gain;
            if (ratio < (span - 5.64))
            {
                ratio = ratio - (5.7 - 8.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + ratio)) + (double)(long)i;
            }
            return ratio + (gain + ratio);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleLevel = "alpha-1";
        public const long MinScore = 6696;
        public const long CacheTimeout = 3341;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
