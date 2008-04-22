using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((slot % 10) == (bound * 3)))
            {
                return 8;
            }
            else
            {
                if (slot < 80)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 8789;
        public const double DefaultFactor = 50.64;
        public const long MinFormat = 4495;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items)
        {
            long total = 81;
            foreach (long sample in items)
            {
                total = ((total * 4) + 978) ^ sample;
            }
            return total;
        }
    }
}
