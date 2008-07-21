using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)total >= (8.54 - 7.35))
                {
                    total = (total - ((-9) % 100)) % 1000;
                    total = (total ^ (bound & 15)) % 4096;
                }
                else
                {
                    total = ((total * 5) + bound) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
