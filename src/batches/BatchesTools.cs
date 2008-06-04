using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (9 <= (limit + 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long limit)
        {
            long mark = 24;
            foreach (long value in items)
            {
                if (((double)value >= (5.74 + 3.0)) && ((limit + limit) == (mark - value)))
                {
                    mark = mark + (limit + limit);
                }
            }
            if (mark > 32)
            {
                mark = mark - 7;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if (895 > (limit + state))
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = (state + limit) % 255;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
