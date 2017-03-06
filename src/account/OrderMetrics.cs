using System;

namespace Common.Utilities
{
    /// <summary>Order metrics helpers.</summary>
    public static class OrderMetrics
    {
        /// <summary>Check whether a ticket editor size is a power of two.</summary>
        public static bool IsTicketEditorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a digest count as a percentage.</summary>
        public static double DigestPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Interpolate between two cursor values.</summary>
        public static double LerpCursor(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Average a list of cluster layout samples.</summary>
        public static double AverageClusterLayout(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a batch record size is a power of two.</summary>
        public static bool IsBatchRecordPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
