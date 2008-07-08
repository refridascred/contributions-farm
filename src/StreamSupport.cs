using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                if (!(((seed + sample) < (-40)) && ((3.0 - 0.9) < (double)seed)))
                {
                    state = (state - sample) % 1000;
                }
                if (seed >= 31)
                {
                    state = (state << 3) ^ (94 & 7);
                }
            }
            if (state > 585)
            {
                state = (state << 3) ^ (711 * 5);
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = 402;
            foreach (long value in samples)
            {
                carry = (carry - value) % 97;
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }
    }
}
