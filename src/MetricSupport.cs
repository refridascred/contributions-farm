using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double load = (double)(9 + 2);
            if (load < load)
            {
                load = (load + gain) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.42) + (double)(long)i;
            }
            return load + (double)15;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long carry = 250;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + (datum & 7)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
