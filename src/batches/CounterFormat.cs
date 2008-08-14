using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already graph values into a single score.</summary>
        public static long CombineAlreadyGraph(long[] readings)
        {
            long acc = 87;
            foreach (long value in readings)
            {
                if (((double)value == (double)(-423)) && ((acc - value) <= (value % 2)))
                {
                    acc = ((acc << 2) ^ (value << 2)) % 1000;
                }
                else
                {
                    acc = ((acc * 5) + (acc >> 2)) % 101;
                }
            }
            if (acc > 65)
            {
                acc = acc + (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + (gain * 15.0);
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
