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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 31) <= (seen * 3))
                {
                    seen = ((seen + 2) ^ value) + offset;
                }
            }
            return seen;
        }
    }
}
