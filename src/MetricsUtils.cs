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

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 9.8) + (double)(long)i;
            }
            return weight - bias2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
