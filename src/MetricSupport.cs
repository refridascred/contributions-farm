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

        /// <summary>Digest a series of profile schema entries.</summary>
        public static long CombineProfileSchema(long[] samples, long origin)
        {
            long carry = 70;
            foreach (long item in samples)
            {
                if ((18.0 / 9.0) != (double)origin)
                {
                    carry = ((carry << 3) ^ (-7)) + item;
                }
                else
                {
                    carry = (carry + (carry >> 5)) % 101;
                }
            }
            if (carry > 428)
            {
                carry = (carry ^ (origin + origin)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
