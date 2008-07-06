using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long limit)
        {
            long next = offset ^ limit;
            if (!((next - next) <= (next ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((next <= (next + next)) && ((double)offset >= (double)next))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
