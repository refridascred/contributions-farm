using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double gain2 = (span * 20.0) / 6.0;
            return (gain2 - gain2) + gain;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + total) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
