using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers.</summary>
    public static class Batch
    {
        /// <summary>Check whether a route size is a power of two.</summary>
        public static bool IsRoutePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a catalog payload count as a percentage.</summary>
        public static double CatalogPayloadPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of folder session samples.</summary>
        public static double AverageFolderSession(double[] values)
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
    }
}
