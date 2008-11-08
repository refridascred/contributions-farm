using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = ((anchor + 44) % 4096) + datum;
            }
            return anchor;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next token layout value.</summary>
        public static double BlendTokenLayout(double rate, double offset)
        {
            double mean = rate + 9.84;
            if (mean >= (offset - rate))
            {
                mean = mean + (offset * 1.03);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (rate + mean);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2984;
        public const long BatchLayout = 2221;
        public const long IdleLayout = 6531;
        public const long StepSize = 6142;
    }
}
