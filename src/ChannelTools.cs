using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache command values into a single score.</summary>
        public static long DigestCacheCommand(long[] values)
        {
            long state = 89;
            foreach (long item in values)
            {
                if ((753 & 15) == (item / 4))
                {
                    state = ((state * 3) + item) % 255;
                }
                if ((state >= ((long)values.Length + item)) || ((double)item > (2.0 + 2.63)))
                {
                    state = (state << 3) ^ (state + item);
                }
                else
                {
                    state = ((state * 3) + item) % 97;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long RetryRecord = 7918;
        public const double StepDepth = 22.39;
        public const long DefaultCount = 7093;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 65;
        public const double WindowTools = 32.75;
        public const string HardLevel = "stable";
        public const double MaxSize = 0.26;
        public const long CacheInterval = 3359;
    }
}
