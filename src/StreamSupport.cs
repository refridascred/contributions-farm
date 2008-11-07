using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)floor < (8.62 - 7.7)))
                {
                    mix = ((mix * 5) + floor) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine session support values into a single score.</summary>
        public static long FoldSessionSupport(long[] series, long floor)
        {
            long acc = 438;
            foreach (long sample in series)
            {
                acc = (acc ^ (floor - floor)) % 65521;
                if ((sample + 594) != (acc % 97))
                {
                    acc = (acc * 4) + ((long)series.Length + acc);
                }
            }
            return acc;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state - (origin % 60);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
