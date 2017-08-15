using System;

namespace Common.Utilities
{
    /// <summary>Batch checks helpers.</summary>
    public static class BatchChecks
    {
        /// <summary>Check whether a already filter size is a power of two.</summary>
        public static bool IsAlreadyFilterPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the decimal digits of a ticket filter id.</summary>
        public static int TicketFilterDigitSum(long n)
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

        /// <summary>Check whether a schema size is a power of two.</summary>
        public static bool IsSchemaPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the decimal digits of a batch id.</summary>
        public static int BatchDigitSum(long n)
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

        /// <summary>Wrap a buffer index into a fixed-size ring.</summary>
        public static int WrapBufferIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
