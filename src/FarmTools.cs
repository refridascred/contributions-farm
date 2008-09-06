using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel buffer value from a seed.</summary>
        public static long StepChannelBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (((state * 3) + (state << 1)) % 97) ^ (long)i2;
                }
                if (((state ^ (-16)) <= state) && ((state / 8) <= (state - (long)i)))
                {
                    state = state + ((long)i % 16);
                    state = state ^ (seed + 7);
                }
                state = state ^ seed;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            New,
            Locked,
            Synced,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
