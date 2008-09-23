using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings, long floor)
        {
            long mark = -524;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - ((long)i >> 1)) % 4096) - floor;
                }
                mark = ((mark << 3) ^ (sample >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long TallyCommandCounter(long[] series, long seed)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((20.0 * 20.0) > (double)datum)
                {
                    mix = (mix << 2) ^ (mix + seed);
                }
            }
            return mix % 97;
        }
    }
}
