using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm support helpers.</summary>
    public static class GithubfarmSupport
    {
        /// <summary>Calculate a 16-bit checksum of a context key.</summary>
        public static int ContextChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Sum the squares of queue record samples.</summary>
        public static double QueueRecordEnergy(double[] values)
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

        /// <summary>Express a catalog count as a percentage.</summary>
        public static double CatalogPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Check whether a layout size is a power of two.</summary>
        public static bool IsLayoutPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
