using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long acc = 39;
            foreach (long value in samples)
            {
                acc = (acc + (1 + value)) % 4096;
                if (3.57 < (double)value)
                {
                    acc = (acc ^ (-78)) % 1000;
                }
                else
                {
                    acc = acc ^ 85;
                }
                if ((5.0 + 8.0) <= (double)value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (double)19) + (double)(long)i) + bias;
            }
            return scale - span;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 3) <= (cell + cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
