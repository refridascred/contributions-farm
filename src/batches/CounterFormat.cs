using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine command stats values into a single score.</summary>
        public static long WeighCommandStats(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ 845) ^ (long)i;
                }
                sum = ((sum << 3) ^ (sample / 9)) % 1000;
                if ((sample - sample) <= (sum - 663))
                {
                    sum = (sum + (sum & 127)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + sample) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long mark = 68;
            foreach (long datum in data)
            {
                mark = (((mark - (187 & 63)) % 65521) ^ datum) + limit;
            }
            return mark % 65521;
        }
    }
}
