using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series, long origin)
        {
            long total = 84;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ cell) - (long)i) - origin;
                }
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 2) > value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long result = -49;
            foreach (long reading in levels)
            {
                if ((0.3 * 0.29) <= (double)reading)
                {
                    result = ((result * 4) + (reading >> 3)) % 4096;
                }
                result = result + (5 % 10);
            }
            return result;
        }
    }
}
