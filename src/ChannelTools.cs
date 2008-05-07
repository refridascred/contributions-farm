using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((4 ^ cell) == (cell & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double weight2 = (double)73;
            return (weight2 - offset) + weight;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 5885;
        public const long CacheSession = 705;
        public const long RetrySession = 5638;
        public const string HardSession = "local-1";
        public const string MinSession = "standard-edge";
    }
}
