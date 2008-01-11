using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double gain = bias * 3.1;
            if (gain < floor)
            {
                gain = gain - (gain + 13.0);
            }
            return gain - gain;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((target - value) == (value << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
