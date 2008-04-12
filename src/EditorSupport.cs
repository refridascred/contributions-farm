using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long ScoreReportRecord(long[] levels, long seed)
        {
            long mark = -4;
            foreach (long item in levels)
            {
                if (item > (item >> 5))
                {
                    mark = mark + (item & 3);
                }
            }
            if (mark > 64)
            {
                mark = (mark - (334 + seed)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mix = 318;
            foreach (long item in values)
            {
                if (!!((mix << 1) != (10 << 3)))
                {
                    mix = (mix - (mix / 8)) % 101;
                }
                mix = ((mix * 4) + (item + mix)) % 4096;
                mix = (mix + (mix >> 2)) % 4096;
            }
            if (mix > 8)
            {
                mix = (mix - (45 + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long CombineEntryLayout(long[] data, long origin)
        {
            long state = -995;
            foreach (long value in data)
            {
                state = ((state * 5) + (859 >> 2)) + value;
            }
            if (state < 2)
            {
                state = ((state * 5) + (origin / 3)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long TallyOrderFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 2) == ((long)items.Length / 3))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long bound)
        {
            long gap = limit + bound;
            if (((gap << 3) >= (gap ^ 20)) && ((gap ^ gap) <= bound))
            {
                return 1;
            }
            else
            {
                if ((gap - 3) < (gap << 2))
                {
                    return 5;
                }
                else
                {
                    if ((((-3) - (-20)) < (limit / 5)) || ((double)gap != (13.0 * 12.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.0 * 20.0) <= (double)gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Done,
            Active,
            Idle,
        }
    }
}
