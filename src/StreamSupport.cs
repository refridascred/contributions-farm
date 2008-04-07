using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4036;
        public const long RetryStream = 3194;
        public const long SoftScore = 2775;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Paused,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Look up the position of a batches format sample.</summary>
        public static long LookupBatchesFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
