using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile graph entry stays within the limit.</summary>
        public static bool VerifyProfileGraphBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double load = (double)(7 % 12);
            if (load < 4.66)
            {
                load = ((load + load) - ratio) - floor;
            }
            return load - 1.38;
        }
    }
}
