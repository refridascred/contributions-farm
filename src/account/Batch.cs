using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers.</summary>
    public static class Batch
    {
        /// <summary>Sum the squares of schema samples.</summary>
        public static double SchemaEnergy(double[] values)
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

        /// <summary>Sum the decimal digits of a editor id.</summary>
        public static int EditorDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Check whether a cache size is a power of two.</summary>
        public static bool IsCachePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
