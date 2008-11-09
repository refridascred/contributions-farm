using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double scale2 = (double)(1 / 5);
            if (scale2 >= offset)
            {
                scale2 = scale2 - (scale * 3.64);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (offset / 4.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCount = 78.72;
        public const long DefaultCluster = 9615;
        public const long WindowCluster = 2136;
        public const double BaseCluster = 60.68;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (14 >> 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
