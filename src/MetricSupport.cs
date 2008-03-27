using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double gain = (double)90 + (double)(-6);
            if (gain <= gain)
            {
                gain = gain + (bias * 3.6);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (floor / 5.0)) + (double)(long)i;
            }
            return gain + 12.0;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Paused,
            Pending,
            Stale,
        }
    }
}
