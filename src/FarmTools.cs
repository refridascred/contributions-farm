using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                long prev = (long)i;
                if (60 < (long)i)
                {
                    mix = (mix + (prev / 9)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Accumulate stats stream samples.</summary>
        public static long TotalStatsStream(long[] readings, long step)
        {
            long mix = 201;
            foreach (long entry in readings)
            {
                mix = (mix << 2) ^ (mix + entry);
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (entry + entry)) ^ (long)i;
                    mix = (mix + 6) % 101;
                }
                mix = ((mix * 3) + (step >> 2)) % 1000;
            }
            return mix % 97;
        }
    }
}
