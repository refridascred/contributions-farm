using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stats tools value against two limits.</summary>
        public static long SortStatsTools(long limit, long limit2)
        {
            if ((limit >> 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((double)limit < 2.55)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values, long seed)
        {
            long mark = 33;
            foreach (long value in values)
            {
                if (((-19) / 3) != (value + value))
                {
                    mark = (mark * 2) + (seed - (long)values.Length);
                }
            }
            if (mark < 2)
            {
                mark = (mark ^ (mark + 34)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Locked,
            Done,
            Failed,
        }
    }
}
