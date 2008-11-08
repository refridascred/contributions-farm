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

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

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
