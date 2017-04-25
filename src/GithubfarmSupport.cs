using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm support helpers.</summary>
    public static class GithubfarmSupport
    {
        /// <summary>Interpolate between two farm stream values.</summary>
        public static double LerpFarmStream(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Calculate a 16-bit checksum of a route key.</summary>
        public static int RouteChecksum(string text)
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

        /// <summary>Clamp a counter value to a valid range.</summary>
        public static double ClampCounter(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a route size is a power of two.</summary>
        public static bool IsRoutePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
