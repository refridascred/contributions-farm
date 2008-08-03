using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already window values into a single score.</summary>
        public static long TotalAlreadyWindow(long[] series)
        {
            long acc = 74;
            foreach (long cell in series)
            {
                if ((double)acc == (6.46 * 3.0))
                {
                    acc = ((acc << 3) ^ (acc >> 2)) + cell;
                }
            }
            if (acc > 86)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two metric order measurements.</summary>
        public static double BlendMetricOrder(double bias, double span)
        {
            double scale = (span - 20.0) - 3.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + span) + (double)(long)i) + bias;
            }
            return scale + span;
        }
    }
}
