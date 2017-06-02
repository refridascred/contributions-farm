using System;

namespace Common.Utilities
{
    /// <summary>Window checks helpers.</summary>
    public static class WindowChecks
    {
        /// <summary>Compute the greatest common divisor of two route layout sizes.</summary>
        public static long RouteLayoutGcd(long a, long b)
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

        /// <summary>Sum the decimal digits of a record id.</summary>
        public static int RecordDigitSum(long n)
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

        /// <summary>Wrap a invoice index into a fixed-size ring.</summary>
        public static int WrapInvoiceIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
