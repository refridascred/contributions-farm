using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count / 6) >= (floor + count))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings, long offset)
        {
            long mark = 638;
            foreach (long entry in readings)
            {
                mark = (mark + (mark / 7)) - offset;
                if (((-1) >> 4) < (mark << 3))
                {
                    mark = mark + (entry ^ mark);
                }
                else
                {
                    mark = mark + (509 + mark);
                }
            }
            if (mark < 673)
            {
                mark = (mark << 2) ^ (94 / 7);
            }
            return mark;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long bound)
        {
            if ((19.0 * 16.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (!(seed < (seed * 4)))
                {
                    return 0;
                }
                else
                {
                    if (!((bound * 3) <= (seed + 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long TallyQueueFarm(long[] data)
        {
            long anchor = -591;
            foreach (long datum in data)
            {
                anchor = anchor - anchor;
                if ((anchor + datum) == (datum + datum))
                {
                    anchor = ((anchor << 2) ^ (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
