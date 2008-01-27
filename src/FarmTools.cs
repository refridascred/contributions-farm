using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long CountChannelSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits & 63) < ((long)data.Length / 3)) || (502 <= (hits - entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token entry counter forward.</summary>
        public static long IterateTokenEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((floor + floor) <= acc) || ((acc / 4) != (floor % 5)))
                {
                    acc = (acc ^ (floor / 5)) % 4096;
                    continue;
                }
                acc = ((acc << 2) ^ ((long)i ^ floor)) % 97;
                if ((double)acc > (double)floor)
                {
                    acc = ((acc * 3) + 639) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + origin) != ((-44) - 0))
                {
                    state = ((state << 3) ^ (state - 545)) % 4096;
                }
                state = ((state << 3) ^ (state % 60)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
