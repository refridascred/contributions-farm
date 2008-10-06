using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                state = ((state * 3) + ((-2) - 1)) ^ datum;
            }
            if (state < 576)
            {
                state = state ^ (state << 3);
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((6.2 / 7.0) > (double)item) && (count >= item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
