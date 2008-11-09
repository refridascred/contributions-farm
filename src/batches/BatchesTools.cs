using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            if (floor <= (floor << 2))
            {
                return 0;
            }
            else
            {
                if ((seed - 11) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema support counter forward.</summary>
        public static long IterateSchemaSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state - (seed / 6)) + (long)i2;
                    state = ((state << 2) ^ state) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
