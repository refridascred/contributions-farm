using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
