using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= (5.9 - drift))
            {
                drift = (drift + (ratio - 7.8)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 8.88) + (double)(long)i;
            }
            return drift + ratio;
        }
    }
}
