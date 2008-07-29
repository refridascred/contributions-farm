using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long seed)
        {
            long offset = step + seed;
            if ((offset * 4) >= (seed ^ step))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset % 100))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ ((long)i % 24)) % 97;
                if (0 < (mix - (long)i))
                {
                    mix = (mix * 5) + (3 % 97);
                    mix = (mix ^ (mix / 6)) % 65521;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + step);
                    mix = (mix << 3) ^ (step + 8);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 3) != (target + 5))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long seed)
        {
            long delta = step + seed;
            if ((7.0 - 7.21) < (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta + delta) != (29 % 5))
                {
                    return 7;
                }
                else
                {
                    if (!((step + step) <= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
