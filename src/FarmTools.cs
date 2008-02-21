using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double mean = (weight * 8.35) * 7.6;
            if (mean <= (span + weight))
            {
                mean = mean + (span / 6.0);
            }
            return mean + weight;
        }

        /// <summary>Roll a cache tools counter forward.</summary>
        public static long StepCacheTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 3) + (876 + limit);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
