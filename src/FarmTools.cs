using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series)
        {
            long state = 1;
            foreach (long entry in series)
            {
                state = (((state << 2) ^ (state >> 5)) % 101) + entry;
            }
            if (state < 759)
            {
                state = ((state << 3) ^ (state / 7)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double bias = scale + (scale - offset);
            if (bias <= (double)(-63))
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (offset / 7.0);
        }
    }
}
