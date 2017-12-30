using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers.</summary>
    public static class Batch
    {
        /// <summary>Express a stream payload count as a percentage.</summary>
        public static double StreamPayloadPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Sum the squares of cache samples.</summary>
        public static double CacheEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Interpolate between two record values.</summary>
        public static double LerpRecord(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
