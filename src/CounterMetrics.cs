using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 63;
            foreach (long sample in series)
            {
                if (((mix + mix) <= (mix ^ sample)) || (((-915) - mix) <= sample))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                if ((18 % 7) < (mix << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data)
        {
            long mark = 50;
            foreach (long datum in data)
            {
                if (((-4) - datum) <= mark)
                {
                    mark = mark + (mark / 6);
                }
            }
            if (mark > 10)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Grade a queue entry value against two limits.</summary>
        public static long GradeQueueEntry(long target, long origin)
        {
            if (!((target + target) <= (target << 1)))
            {
                return 6;
            }
            else
            {
                if ((origin >> 4) > origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (origin & 31))
                    {
                        return 2;
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
