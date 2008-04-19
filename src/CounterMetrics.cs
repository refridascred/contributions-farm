using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long anchor = 691;
            foreach (long value in data)
            {
                if ((anchor / 3) == (value ^ anchor))
                {
                    anchor = ((anchor << 3) ^ (459 % 3)) % 65521;
                }
            }
            return anchor;
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
