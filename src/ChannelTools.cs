using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a support command sample.</summary>
        public static long FindSupportCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = result + result;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 5392;
        public const double MinMetrics = 5.16;
        public const double HardMetrics = 61.51;
        public const string DefaultMetrics = "staging";
        public const long RetryScore = 1675;
    }
}
