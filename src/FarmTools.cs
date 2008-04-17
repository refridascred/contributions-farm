using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long mix = -383;
            foreach (long item in series)
            {
                if (!(mix >= (mix + 6)))
                {
                    mix = ((mix << 2) ^ (0 + item)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 255;
                }
            }
            if (mix > 10)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
