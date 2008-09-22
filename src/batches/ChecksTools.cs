using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3960;
        public const string WindowSpan = "local-1";
        public const string DefaultMetrics = "latest-edge";

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long seed)
        {
            long state = 7;
            foreach (long entry in readings)
            {
                state = (state ^ (entry ^ seed)) % 4096;
                if ((double)state < 8.53)
                {
                    break;
                }
            }
            if (state > 767)
            {
                state = (state - (962 >> 3)) % 97;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
