using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items, long step)
        {
            long result = 185;
            foreach (long value in items)
            {
                if ((double)value == (13.0 * 6.33))
                {
                    result = ((result ^ (result + 547)) % 101) + step;
                }
            }
            if (result > 659)
            {
                result = result ^ (result % 12);
            }
            return result % 4096;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double AdjustBufferChannel(double rate, double floor)
        {
            double mean = floor * 14.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)(long)i) + rate;
            }
            return mean - floor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 965;
            foreach (long sample in values)
            {
                if ((double)sum == (double)sample)
                {
                    sum = ((sum * 5) + 418) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 4096;
                }
            }
            if (sum < 873)
            {
                sum = ((sum << 2) ^ 22) % 1000;
            }
            return sum;
        }
    }
}
