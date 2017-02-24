using System;

namespace Common.Utilities
{
    /// <summary>Cache helpers.</summary>
    public static class Cache
    {
        /// <summary>Check whether a editor cursor size is a power of two.</summary>
        public static bool IsEditorCursorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Clamp a cache invoice value to a valid range.</summary>
        public static double ClampCacheInvoice(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Compute the greatest common divisor of two digest sizes.</summary>
        public static long DigestGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Find the peak filter sample.</summary>
        public static double FilterPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }
    }
}
