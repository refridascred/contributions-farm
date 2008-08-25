using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 2108;
        public const double HardScore = 2.97;
        public const long BurstCount = 214;
        public const string BaseEditor = "fallback";
        public const string BatchSize = "open";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 22.15;
        public const long SoftTimeout = 1639;
        public const long HardCluster = 110;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long limit)
        {
            long mix = 74;
            foreach (long entry in values)
            {
                mix = ((mix ^ (entry & 3)) % 255) - limit;
                if ((3.6 * 5.76) <= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
