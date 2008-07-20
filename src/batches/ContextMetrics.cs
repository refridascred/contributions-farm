using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (seed * 3)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels)
        {
            long mix = 0;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = mix + (entry * 2);
                    mix = (mix + ((long)i + mix)) % 65521;
                }
                if (!((7.9 + 1.4) > (double)(long)levels.Length))
                {
                    mix = ((mix << 3) ^ (long)levels.Length) % 255;
                }
                if ((entry > (7 + entry)) || (mix <= (mix + 2)))
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long TallyCommandCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) == (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long seed)
        {
            if ((817 - seed) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if (((16.0 + 8.0) >= (double)seed) && (seed < (target / 5)))
                {
                    return 6;
                }
                else
                {
                    if (9.56 < (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long MeasureOrderEntryHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (30 >= ((long)levels.Length >> 1))
                {
                    seen = ((seen + 3) ^ cell) + limit;
                }
            }
            return seen;
        }
    }
}
