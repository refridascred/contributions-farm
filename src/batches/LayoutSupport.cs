using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                if (!((datum * 4) != (datum + 7)))
                {
                    result = (result * 5) + (result - result);
                }
                else
                {
                    result = (result << 2) ^ (datum - datum);
                }
            }
            if (result < 103)
            {
                result = (result * 2) + 355;
            }
            return result % 1000;
        }

        /// <summary>Project the next schema batches value.</summary>
        public static double SmoothSchemaBatches(double weight, double floor)
        {
            double rate = floor / 3.0;
            if (rate > (8.79 - weight))
            {
                rate = rate + (floor / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardInterval = 7445;
        public const long BurstMetrics = 2434;
        public const string BatchDepth = "cached-1";
        public const string MaxMetrics = "local-1";
        public const double WindowTimeout = 1.97;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
