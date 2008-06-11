using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit < (total - limit)) && ((6.0 / 4.0) <= (double)total))
                {
                    total = total - (total % 16);
                    total = (total ^ (total >> 2)) % 4096;
                }
                total = ((total << 3) ^ (limit >> 1)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double scale = (double)(-704) / 5.0;
            if (scale <= (span * 6.33))
            {
                scale = (scale + (double)731) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale - (span / 4.0);
        }
    }
}
