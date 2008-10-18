using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < 5.8)
            {
                rate2 = (rate2 + (rate2 - offset)) + rate;
            }
            return rate2 + (rate2 / 8.0);
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

        /// <summary>Check that every editor buffer entry stays within the limit.</summary>
        public static bool GuardEditorBufferLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
