using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxCount = 9926;
        public const string IdleCount = "legacy";
        public const double LimitTimeout = 22.92;
        public const long RetryScore = 8334;

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 96.45;
        public const double BaseTools = 23.46;
        public const long DefaultDepth = 7938;
    }
}
