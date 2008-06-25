using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (((-8) - offset) <= (seed + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first payload report entry that matches the target.</summary>
        public static long LocatePayloadReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const double MaxGraph = 47.71;
        public const long HardInterval = 551;
    }
}
