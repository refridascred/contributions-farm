using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string RetrySize = "stable-v2";
        public const long BurstBatches = 3144;
        public const long StepDepth = 526;
        public const long BatchBatches = 7554;
        public const long BatchBudget = 8841;

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "stable-edge";
        public const string CacheSupport = "cached-1";
        public const double BurstSupport = 85.7;
        public const double IdleSpan = 41.89;
        public const long RetrySupport = 6303;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
