using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio + floor)) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
