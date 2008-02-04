using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 83.48;
        public const long SoftCommand = 5141;
        public const long BaseCommand = 9854;
        public const long BaseScore = 3460;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + (28 + limit)) % 255;
                sum = (sum << 3) ^ limit;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result - bound;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = (gain + gain) - offset;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight * 10.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
