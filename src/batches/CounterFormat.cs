using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((floor + 24) < item)
                {
                    anchor = ((anchor << 2) ^ (item / 8)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (floor + item)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const double BaseBudget = 10.3;
        public const double SoftSpan = 50.19;
    }
}
