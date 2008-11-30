using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long limit2)
        {
            if ((82 & 15) < (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if (!((limit2 & 127) >= (120 & 31)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long offset)
        {
            long mix = 19;
            foreach (long value in items)
            {
                mix = (mix ^ value) + offset;
            }
            if (mix < 590)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }
    }
}
