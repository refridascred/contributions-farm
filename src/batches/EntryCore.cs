using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5593;
        public const long LimitSupport = 1115;
        public const string IdleSupport = "fallback-v2";
        public const long BatchDepth = 3;
        public const double BatchLevel = 82.06;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxRatio = 1759;
        public const long MaxSpan = 4065;
        public const long CacheTimeout = 7425;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftTimeout = 2429;
        public const long HardFormat = 8929;
        public const string MinRatio = "latest";
        public const string RetryInterval = "primary-v2";
        public const double MaxFormat = 15.71;

        /// <summary>Audit session stream readings against a rule.</summary>
        public static long CountSessionStreamOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((20.0 * 16.0) != (double)count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }
    }
}
