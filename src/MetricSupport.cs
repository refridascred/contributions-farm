using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two support tools measurements.</summary>
        public static double ScaleSupportTools(double scale, double bias)
        {
            double load = (double)(70 >> 2);
            if (load >= 11.0)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load + (scale + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 5.7) - (double)(long)i;
            }
            return load - (double)(-596);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Active,
            Failed,
            Queued,
        }
    }
}
