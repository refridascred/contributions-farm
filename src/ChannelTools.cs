using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "stable-v2";
        public const long BatchTimeout = 5429;
        public const long BaseFilter = 4688;
        public const long StepScore = 1267;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double offset)
        {
            double weight = (double)(498 + 5);
            if (weight < (double)658)
            {
                weight = weight - (double)20;
            }
            else
            {
                weight = weight - offset;
            }
            return weight - ratio;
        }
    }
}
