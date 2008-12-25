using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (offset > (offset >> 1))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long state = 7;
            foreach (long item in data)
            {
                if (state <= (480 >> 4))
                {
                    state = ((state ^ offset) % 101) - item;
                }
                state = state + (state >> 1);
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long floor)
        {
            long result = 37;
            foreach (long reading in data)
            {
                if (((long)data.Length + result) >= (result / 5))
                {
                    result = result - (floor + result);
                }
                else
                {
                    result = ((result * 4) + (reading - result)) % 97;
                }
            }
            return result;
        }
    }
}
