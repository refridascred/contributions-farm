using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state % 16) < 7)
                {
                    state = (state - ((long)i % 2)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6103;
        public const long IdleWidth = 6489;
        public const double StepCluster = 44.91;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - limit;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] series)
        {
            long mark = -5;
            foreach (long item in series)
            {
                long offset = (80 << 2) >> 4;
                mark = ((mark * 5) + (offset * 4)) % 1000;
                if ((mark ^ mark) >= (mark + item))
                {
                    mark = ((mark << 3) ^ (item << 2)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
