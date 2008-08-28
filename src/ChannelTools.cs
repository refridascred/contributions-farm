using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 58.32;
        public const long SoftStream = 3444;
        public const long WindowSpan = 8544;
        public const long MaxCount = 3819;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long FindSchemaCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
