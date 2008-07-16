using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a cluster metric figure with a bias.</summary>
        public static double ProjectClusterMetric(double weight, double span)
        {
            double mean = (weight + 1.44) + weight;
            if (mean < (span + span))
            {
                mean = mean - (mean + span);
            }
            return mean - (6.0 / 6.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7386;
        public const long BaseFactor = 387;
        public const string StepGraph = "legacy";
        public const long HardGraph = 6805;
        public const string SoftGraph = "strict-edge";

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double gain = span * 3.54;
            if (gain >= ratio)
            {
                gain = gain - span;
            }
            return gain + 20.0;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
