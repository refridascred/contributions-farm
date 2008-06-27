using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((result >> 3) >= (cell * 3))
                {
                    result = (result * 5) + (68 / 3);
                }
            }
            if (result < 7)
            {
                result = result + (524 & 1);
            }
            return result;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Iterate the checks profile series from a seed.</summary>
        public static long IterateChecksProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - (target - target)) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
