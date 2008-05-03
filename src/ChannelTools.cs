using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support buffer reading by value.</summary>
        public static long LookupSupportBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter window entry stays within the limit.</summary>
        public static bool ValidateCounterWindowBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long state = 487;
            foreach (long sample in readings)
            {
                if (531 < sample)
                {
                    state = (state ^ (state + bound)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (4 - sample)) % 97;
                }
            }
            if (state > 3)
            {
                state = ((state * 3) + (bound % 64)) % 97;
            }
            return state;
        }
    }
}
