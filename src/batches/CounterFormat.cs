using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Blend two order graph measurements.</summary>
        public static double ScaleOrderGraph(double scale, double span)
        {
            double rate = (double)40 / 3.0;
            if (rate < (span + rate))
            {
                rate = rate + (scale + 4.36);
            }
            return rate + (double)60;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
