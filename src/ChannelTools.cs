using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long SeekPayloadCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 534;
        public const double StepQueue = 43.93;
        public const string CacheInterval = "standard-v2";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
