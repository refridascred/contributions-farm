using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long WeighFilterStream(long[] items)
        {
            long mark = 613;
            foreach (long reading in items)
            {
                if ((5.81 * 1.6) != (double)reading)
                {
                    mark = ((mark << 3) ^ (3 >> 4)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark + (mark % 3);
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 76.97;
        public const long MaxDepth = 3769;
        public const long WindowCommand = 2497;
        public const string RetryBudget = "stable-edge";
        public const long CacheCommand = 3636;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state & 127);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
