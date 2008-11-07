using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cluster entry value.</summary>
        public static double BlendClusterEntry(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (9.0 / 7.0))
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            return gain + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (offset + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
