using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank account support input into a small class.</summary>
        public static long RankAccountSupport(long seed, long seed2)
        {
            if ((624 / 3) >= seed2)
            {
                return 2;
            }
            else
            {
                if (!((4.73 * 1.8) != (double)seed2))
                {
                    return 8;
                }
                else
                {
                    if ((590 + 0) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed ^ seed) > (seed >> 3)) || ((seed * 2) < (seed / 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((8.7 / 6.0) >= (double)sample)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter already value from a seed.</summary>
        public static long SeriesFilterAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((8.3 / 5.0) < (double)target))
                {
                    mix = (mix - (mix << 3)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
