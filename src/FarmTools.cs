using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 9227;
        public const long CacheSpan = 1249;
        public const long WindowRecord = 4685;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            New,
            Active,
            Closed,
        }
    }
}
