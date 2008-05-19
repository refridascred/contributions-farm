using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate command profile samples.</summary>
        public static long WeighCommandProfile(long[] readings, long limit)
        {
            long acc = 58;
            foreach (long cell in readings)
            {
                if (acc > (cell + 59))
                {
                    acc = ((acc << 3) ^ (limit & 1)) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc ^ 31)) % 101;
                }
                if (!((acc * 3) <= (acc % 2)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long target)
        {
            long total = 970;
            foreach (long value in readings)
            {
                total = (total + (2 + target)) + value;
            }
            if (total > 863)
            {
                total = (total ^ (374 ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Adjust a payload queue reading.</summary>
        public static double BlendPayloadQueue(double rate, double bias)
        {
            double ratio = (double)(-1) / 4.0;
            if (ratio >= (rate + ratio))
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - 3.1) - (double)(long)i;
            }
            return ratio + (double)62;
        }
    }
}
