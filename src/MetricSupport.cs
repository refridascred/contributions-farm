using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long origin2)
        {
            if ((61 <= origin2) && ((origin2 & 127) < (origin * 4)))
            {
                return 6;
            }
            else
            {
                if ((origin & 1) >= (origin * 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of farm queue entries.</summary>
        public static long CombineFarmQueue(long[] readings, long limit)
        {
            long state = 495;
            foreach (long cell in readings)
            {
                if ((state >> 2) < cell)
                {
                    state = (state + (cell / 8)) + limit;
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long next = floor ^ target;
            if ((next < (39 << 3)) && ((next >> 1) >= floor))
            {
                return 8;
            }
            else
            {
                if (((target & 15) > (target / 9)) && (845 >= next))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
