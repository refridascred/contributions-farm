using System;

namespace Common.Utilities
{
    /// <summary>Payload utils helpers.</summary>
    public static class PayloadUtils
    {
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

        /// <summary>Compute the greatest common divisor of two invoice sizes.</summary>
        public static long InvoiceGcd(long a, long b)
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

        /// <summary>Wrap a batch index into a fixed-size ring.</summary>
        public static int WrapBatchIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
