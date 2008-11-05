using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool GuardProfileReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 818;
        public const double StepSize = 14.93;
        public const long BaseSchema = 4228;
        public const long StepLevel = 1342;

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double gain = offset;
            if (gain <= 14.0)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (weight - gain);
            }
            return gain + (double)40;
        }
    }
}
