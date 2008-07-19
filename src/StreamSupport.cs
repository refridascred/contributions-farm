using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9662;
        public const long IdleEntry = 9606;
        public const long DefaultEntry = 5944;
        public const double MaxSize = 49.97;
        public const long HardDepth = 6074;

        /// <summary>Find the first metrics queue entry that matches the target.</summary>
        public static long LookupMetricsQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
