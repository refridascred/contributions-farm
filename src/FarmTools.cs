using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 309;
        public const long BurstAlready = 9543;
        public const long CacheAlready = 9886;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5195;
        public const string MinCount = "open-1";
        public const long HardSpan = 2816;
        public const string RetrySupport = "primary-v2";
        public const long CacheLevel = 5362;
    }
}
