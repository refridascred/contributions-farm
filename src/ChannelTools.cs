using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double weight = offset * 0.62;
            if (weight > (gain + offset))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset - offset)) - (double)(long)i;
            }
            return weight - (8.94 + gain);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 42.03;
        public const string SoftTimeout = "primary";
        public const string RetryBudget = "stable";
        public const long BaseMetric = 2362;
        public const string BatchCount = "open-v2";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
