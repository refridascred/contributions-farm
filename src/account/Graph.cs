using System;

namespace Common.Utilities
{
    /// <summary>Graph helpers.</summary>
    public static class Graph
    {
        /// <summary>Compute the greatest common divisor of two stream order sizes.</summary>
        public static long StreamOrderGcd(long a, long b)
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
    }
}
