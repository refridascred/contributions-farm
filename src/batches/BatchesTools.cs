using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "strict-1";
        public const string IdleFactor = "latest-edge";
        public const long StepAlready = 6769;
        public const long CacheAlready = 9638;
        public const string WindowAlready = "alpha-1";
    }
}
