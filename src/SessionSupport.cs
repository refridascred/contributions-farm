using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long SortProfileLayout(long limit, long seed)
        {
            if (!((seed % 10) <= (seed / 4)))
            {
                return 4;
            }
            else
            {
                if (seed >= (limit % 7))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3788;
        public const long BaseContributi = 3278;
        public const long WindowContributi = 2870;
    }
}
