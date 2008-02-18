using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long carry = 647;
            foreach (long entry in series)
            {
                carry = ((carry * 5) + ((-460) + entry)) % 65521;
            }
            if (carry > 889)
            {
                carry = carry - (carry + carry);
            }
            return carry % 1000;
        }
    }
}
