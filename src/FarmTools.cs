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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long step)
        {
            if ((limit % 2) == (step + step))
            {
                return 2;
            }
            else
            {
                if ((limit <= (step % 60)) && ((96 & 255) == (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
