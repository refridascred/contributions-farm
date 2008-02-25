using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 3) <= (92 / 9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 8798;
        public const long StepStream = 5264;
        public const long WindowSize = 1962;
        public const long DefaultScore = 3226;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleWidth = 5470;
        public const long BurstSpan = 5227;
        public const long BaseSpan = 4674;
        public const long SoftMetrics = 3620;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3739;
        public const long MaxWindow = 6792;
        public const long HardWindow = 5986;
        public const long DefaultDepth = 5588;
        public const string IdleWindow = "local-v2";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
