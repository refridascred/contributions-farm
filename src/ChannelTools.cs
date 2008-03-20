using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor << 2) >= 13)
                {
                    total = (total ^ (total % 100)) % 101;
                }
                total = (total << 3) ^ (total + total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            if ((seed / 2) != (offset - seed))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (9.8 + 2.73)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                long gap = sum;
                if ((309 % 64) >= (gap + (long)i))
                {
                    gap = gap + gap;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
