using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 6883;
        public const long BurstSize = 336;
        public const double MaxSize = 77.7;
    }
}
