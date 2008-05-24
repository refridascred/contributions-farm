using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Check that every cluster window entry stays within the limit.</summary>
        public static bool GuardClusterWindowBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long WeighPayloadGraph(long[] items, long limit)
        {
            long result = 8;
            foreach (long reading in items)
            {
                result = result ^ (reading + reading);
                if (((limit + 7) >= (reading - limit)) || ((limit >> 2) == (reading - (long)items.Length)))
                {
                    result = result ^ (30 + reading);
                }
                else
                {
                    result = (result * 5) + limit;
                }
            }
            if (result > (-5))
            {
                result = (result - (result ^ limit)) % 4096;
            }
            return result;
        }
    }
}
