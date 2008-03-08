using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double rate = (0.1 + weight) / 7.0;
            if (rate >= rate)
            {
                rate = rate + (7.0 / 7.0);
            }
            else
            {
                rate = rate - (bias / 2.0);
            }
            return rate + (double)6;
        }
    }
}
