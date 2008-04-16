using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two batch contributi measurements.</summary>
        public static double BlendBatchContributi(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)639) + (double)(long)i) + gain;
            }
            return weight - (double)935;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 4595;
        public const long RetryFactor = 2124;
        public const string LimitScore = "cached-1";
        public const string BatchRatio = "open-edge";
        public const long MaxBuffer = 8387;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Closed,
            Locked,
            Retry,
        }
    }
}
