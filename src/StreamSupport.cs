using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool VerifyTokenQueueRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 1736;
        public const string BaseTimeout = "latest";
        public const long DefaultProfile = 5185;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double span)
        {
            double rate = (double)(134 + 8);
            if (rate < (rate * 6.7))
            {
                rate = ((rate - (1.89 + rate)) - bias) + span;
            }
            return rate + (rate - rate);
        }
    }
}
