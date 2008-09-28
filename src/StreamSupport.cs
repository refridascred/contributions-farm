using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long offset)
        {
            long delta = seed - offset;
            if ((delta ^ offset) != (seed * 2))
            {
                return 6;
            }
            else
            {
                if (((double)offset <= (20.0 / 5.0)) || ((delta % 64) <= (offset * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            if ((5.08 + 17.0) > (double)target)
            {
                return 6;
            }
            else
            {
                if (!((origin << 3) < origin))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (anchor + (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
