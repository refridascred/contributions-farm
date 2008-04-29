using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 61;
            foreach (long cell in items)
            {
                total = (total + ((-235) / 4)) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Roll a payload context counter forward.</summary>
        public static long RollPayloadContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long CountContributiRecordGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (7.8 > (double)floor)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
