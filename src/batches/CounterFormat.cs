using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 1376;
        public const string MinFactor = "standard-v2";
        public const string LimitSession = "fallback-v2";
        public const long StepSession = 8620;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
