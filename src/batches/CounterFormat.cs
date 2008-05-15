using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long step)
        {
            long state = -8;
            foreach (long reading in items)
            {
                state = (state - (step ^ 79)) % 255;
                if ((31 >> 5) == (state * 3))
                {
                    state = (state << 2) ^ reading;
                }
                if (!((step & 1) <= (reading * 3)))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }
    }
}
