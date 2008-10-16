using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Active,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "cached-1";
        public const long SoftToken = 3147;
        public const long HardCount = 6562;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                if ((state + state) <= ((long)i - state))
                {
                    state = (state << 3) ^ state;
                }
                else
                {
                    state = (state - step) % 1000;
                    state = state + (state - step);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
