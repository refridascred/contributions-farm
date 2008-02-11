using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double scale = gain;
            if (scale < (span / 2.0))
            {
                scale = scale + (9.0 * 0.7);
            }
            return scale + (double)70;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix % 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long offset)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state << 2) ^ (offset / 8)) % 255) - (long)i;
                }
                if (99 < offset)
                {
                    state = (state ^ (reading >> 5)) % 4096;
                }
                else
                {
                    state = (state + offset) % 65521;
                }
            }
            return state;
        }
    }
}
