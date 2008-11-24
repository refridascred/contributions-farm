using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] samples, long floor)
        {
            long state = 311;
            foreach (long item in samples)
            {
                if ((floor + state) > (item + 112))
                {
                    state = (state << 2) ^ ((long)samples.Length >> 2);
                }
                state = (state * 5) + (floor >> 5);
            }
            if (state < 16)
            {
                state = (state ^ (long)samples.Length) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
