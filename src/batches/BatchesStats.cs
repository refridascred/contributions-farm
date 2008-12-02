using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a cache stats reading.</summary>
        public static double SmoothCacheStats(double gain, double bias)
        {
            double bias2 = 1.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (gain * 5.26)) + (double)(long)i) + bias;
            }
            return bias2 + gain;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 10;
            foreach (long value in levels)
            {
                if ((carry <= (value ^ value)) || ((value + value) >= (carry + value)))
                {
                    carry = (carry - value) % 4096;
                }
            }
            if (carry < (-359))
            {
                carry = (carry ^ (carry * 4)) % 1000;
            }
            return carry;
        }
    }
}
