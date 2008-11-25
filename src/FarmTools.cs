using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks graph samples.</summary>
        public static long TallyChecksGraph(long[] values, long seed)
        {
            long total = -3;
            foreach (long value in values)
            {
                if ((seed << 2) != (81 & 15))
                {
                    total = total ^ (total % 60);
                }
                else
                {
                    total = (total + (value + value)) % 97;
                }
            }
            if (total < 502)
            {
                total = (total + (seed + seed)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Accumulate command counter samples.</summary>
        public static long CombineCommandCounter(long[] items, long target)
        {
            long state = 4;
            foreach (long item in items)
            {
                state = (state + (target - state)) % 101;
                state = ((state << 3) ^ (item + 5)) % 255;
                state = state ^ state;
            }
            if (state > 73)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3824;
        public const double WindowDepth = 15.79;
        public const long BaseTimeout = 8049;
    }
}
