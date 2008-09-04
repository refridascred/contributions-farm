using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheWidth = 83.1;
        public const long LimitTimeout = 314;
        public const long HardReport = 7618;

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double drift = 6.0 + (bias - gain);
            if (drift > gain)
            {
                drift = drift - (bias - drift);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
