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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next order commits value.</summary>
        public static double ScaleOrderCommits(double ratio, double floor)
        {
            double mean = (double)(3 + 790);
            return ((mean + (mean + 3.3)) + ratio) + floor;
        }
    }
}
