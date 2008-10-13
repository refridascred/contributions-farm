using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseLevel = "latest-v2";
        public const string RetryRatio = "open-edge";
        public const long IdleBatch = 6148;
        public const long BaseBatch = 5611;

        /// <summary>Derive the next filter queue value from a seed.</summary>
        public static long RollFilterQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
