using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset ^ (-8)) >= (offset - next))
            {
                return 1;
            }
            else
            {
                if (((next + offset) <= (next << 3)) || (origin <= (offset + origin)))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long mix = 83;
            foreach (long cell in series)
            {
                if (!((double)cell < (8.46 / 6.0)))
                {
                    mix = (mix * 3) + (long)series.Length;
                }
                if ((cell - 898) == (cell >> 1))
                {
                    mix = (mix + mix) % 101;
                }
            }
            if (mix < 91)
            {
                mix = (mix + (mix + (-4))) % 255;
            }
            return mix % 1000;
        }
    }
}
