using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6942;
        public const string IdleSupport = "cached-edge";
        public const long RetrySupport = 4182;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "strict";
        public const string RetryInterval = "strict-1";
        public const long SoftDepth = 4088;
    }
}
