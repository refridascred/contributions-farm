using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double rate = span;
            if (rate >= (span / 2.0))
            {
                rate = (rate + (double)468) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span / 4.0)) + (double)(long)i;
            }
            return rate - (span * 8.7);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double weight, double offset)
        {
            double drift = offset * 7.03;
            if (drift <= (weight - drift))
            {
                drift = drift - (double)634;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - offset;
        }
    }
}
