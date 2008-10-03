using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = ratio * 10.0;
            if (drift >= (double)60)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - ratio;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - offset;
            }
            return weight - weight;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 2211;
        public const long HardWidth = 4731;
        public const double BaseEditor = 53.43;
        public const string BurstTimeout = "open-edge";
    }
}
