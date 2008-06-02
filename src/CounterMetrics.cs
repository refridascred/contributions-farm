using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a command entry reading.</summary>
        public static double SmoothCommandEntry(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > (double)5)
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (5.79 - 2.5)) - (double)(long)i;
            }
            return bias2 + (double)62;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Done,
            Active,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                sum = ((sum ^ value) % 1000) + bound;
            }
            return sum % 4096;
        }
    }
}
