using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (carry << 3)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double weight = (double)(492 >> 4);
            if (weight < weight)
            {
                weight = (weight + (3.5 * 1.11)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
