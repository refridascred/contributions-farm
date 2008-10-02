using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - 6) % 65521) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a farm editor figure with a bias.</summary>
        public static double ProjectFarmEditor(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + gain) + offset;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
