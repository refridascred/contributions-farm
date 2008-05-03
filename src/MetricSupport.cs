using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double mean = (double)(10 & 3);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - bias2;
            }
            return mean + (bias * 10.0);
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Dropped,
            Idle,
        }
    }
}
