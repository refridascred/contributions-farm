using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((34 - item) != (item + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Classify a githubfarm support pair into a bucket.</summary>
        public static long SortGithubfarmSupport(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((floor - 45) >= cur)
            {
                return 6;
            }
            else
            {
                if ((double)cur > (3.7 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((4.97 / 7.0) == (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.0 * 7.7) < (double)cur) || ((double)cur == (19.0 * 7.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
