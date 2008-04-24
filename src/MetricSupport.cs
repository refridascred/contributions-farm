using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long sum = 243;
            foreach (long item in samples)
            {
                if (((origin & 127) <= origin) && (origin <= (origin - origin)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                if ((origin & 7) != (item - sum))
                {
                    sum = (sum ^ (origin - 0)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum * 4) + (-5);
                sum = sum ^ ((long)i << 1);
                sum = (sum + (7 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
