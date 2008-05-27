using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const string StepRatio = "standard-edge";
        public const long IdleBatch = 3227;

        /// <summary>Compare every pair of cache account readings.</summary>
        public static long CompareCacheAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 3520;
        public const string MaxBuffer = "cached-edge";
        public const long CacheInterval = 22;
    }
}
