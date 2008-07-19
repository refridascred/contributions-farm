using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double ratio = (floor * 8.0) - 4.9;
            if (ratio <= 1.67)
            {
                ratio = ratio + (floor + ratio);
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio - gain;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
