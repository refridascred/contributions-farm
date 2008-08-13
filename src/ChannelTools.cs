using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable";
        public const string CacheWindow = "local-edge";
        public const string CacheRatio = "staging-edge";
        public const string CacheDepth = "strict-1";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches != (double)6)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
