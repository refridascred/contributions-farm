using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i <= ((long)i + (long)i))
                {
                    state = ((state * 4) + (offset - offset)) % 4096;
                    state = (state * 5) + (offset + (long)i);
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 25.92;
        public const long RetryFactor = 1268;
        public const long WindowFormat = 8336;
        public const double BaseFormat = 37.52;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
