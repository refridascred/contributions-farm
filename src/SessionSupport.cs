using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a stream report reading.</summary>
        public static double AdjustStreamReport(double gain, double floor)
        {
            double drift = (gain + 3.47) - 7.75;
            if (drift <= (double)20)
            {
                drift = drift - (drift + floor);
            }
            else
            {
                drift = drift - (double)3;
            }
            return drift + gain;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
