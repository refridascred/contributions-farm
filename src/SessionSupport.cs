using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if ((bound - bound) < (offset + bound))
            {
                return 1;
            }
            else
            {
                if ((offset * 2) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (8.73 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 6861;
        public const long BurstInterval = 9455;
        public const long LimitCounter = 9083;
        public const string DefaultCounter = "standard-v2";

        /// <summary>Locate a context queue reading by value.</summary>
        public static long LookupContextQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
