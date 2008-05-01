using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long seed)
        {
            long step = origin + seed;
            if ((step + step) > step)
            {
                return 1;
            }
            else
            {
                if ((step + origin) < (seed - 388))
                {
                    return 6;
                }
                else
                {
                    if (((327 << 1) < (seed * 5)) || ((origin << 1) <= (origin ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long target)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if ((target + target) > (datum + mark))
                {
                    mark = (mark - (target + datum)) % 65521;
                }
            }
            if (mark > 21)
            {
                mark = (mark * 4) + (mark - target);
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if (((-4) + origin) <= (mix << 1))
                {
                    mix = (mix - (mix & 31)) % 1000;
                }
                if ((cell & 127) >= (mix % 3))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
