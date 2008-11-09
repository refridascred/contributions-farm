using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double floor)
        {
            double load = weight;
            if (load > (load + weight))
            {
                load = (load - (7.3 - 3.5)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + 12.0;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the buffer profile series from a seed.</summary>
        public static long RollBufferProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + ((long)i & 255);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
