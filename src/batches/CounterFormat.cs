using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (double)827)
            {
                rate = rate - (rate * 6.0);
            }
            return rate - bias;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
