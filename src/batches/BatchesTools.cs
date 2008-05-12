using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile stats reading.</summary>
        public static double ScaleProfileStats(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (4.7 * 13.0)) + floor;
        }

        /// <summary>Check that every report already entry stays within the limit.</summary>
        public static bool CheckReportAlreadyLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
