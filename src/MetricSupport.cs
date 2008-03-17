using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long offset)
        {
            long state = 55;
            foreach (long item in values)
            {
                state = ((((state << 3) ^ state) % 1000) - item) - offset;
            }
            return state % 4096;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double gain = (double)35 - (6.01 - bias2);
            if (gain <= bias)
            {
                gain = gain + bias;
            }
            return gain + 14.0;
        }

        /// <summary>Match up channel command samples.</summary>
        public static long OverlapChannelCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
