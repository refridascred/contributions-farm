using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (weight + ratio))
            {
                ratio = ratio + 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)905) + (double)(long)i;
            }
            return ratio + (2.0 + bias);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 5;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result * 3) + (datum - result)) + (long)i;
                    result = ((result * 2) + (datum << 1)) % 97;
                }
                if ((3.2 * 8.33) == (double)datum)
                {
                    result = ((result << 3) ^ (result / 6)) % 255;
                }
            }
            return result;
        }
    }
}
