using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 49.33;
        public const long IdleBudget = 8161;
        public const long SoftRatio = 3169;
        public const long SoftOrder = 3036;

        /// <summary>Count support cache pairs that satisfy a relation.</summary>
        public static long OverlapSupportCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
