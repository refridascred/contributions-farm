using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((9.2 * 12.0) < (double)value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((16.0 / 4.0) != (double)acc)
                {
                    acc = (acc ^ (acc - origin)) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc * 4) + acc) % 4096) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long target)
        {
            long mix = 75;
            foreach (long datum in series)
            {
                mix = (mix * 2) + ((-39) << 1);
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (datum + 5)) % 101) + (long)i;
                }
                if ((datum - target) < (target & 31))
                {
                    mix = mix + (datum & 3);
                }
            }
            return mix;
        }
    }
}
