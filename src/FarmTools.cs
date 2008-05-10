using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "cached-edge";
        public const double LimitStream = 48.97;
        public const long DefaultStream = 9605;
        public const double HardTimeout = 7.09;
        public const long StepStream = 2389;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long anchor = 66;
            foreach (long datum in readings)
            {
                if ((datum / 6) >= (anchor / 6))
                {
                    anchor = anchor + (bound + bound);
                }
                else
                {
                    anchor = (anchor - (60 & 63)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 1.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)319) + (double)(long)i;
            }
            return gain + (double)6;
        }
    }
}
