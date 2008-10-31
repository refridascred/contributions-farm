using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long sum = 66;
            foreach (long item in samples)
            {
                if (((sum + item) == (item - sum)) && ((item + 7) == (item + sum)))
                {
                    sum = (sum ^ (sum - 2)) % 4096;
                }
                if ((603 >> 3) > (sum - sum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double rate = (floor - weight) + weight;
            if (rate < rate)
            {
                rate = rate - (floor - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 4.44) + (double)(long)i;
            }
            return rate + (rate - floor);
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (mark + (long)i)) % 65521;
                if ((double)target <= 2.65)
                {
                    mark = (mark - 231) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
