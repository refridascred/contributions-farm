using System;

namespace Common.Utilities
{
    /// <summary>Editor format helpers.</summary>
    public static class EditorFormat
    {
        /// <summary>Wrap a catalog index into a fixed-size ring.</summary>
        public static int WrapCatalogIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Check whether a queue ticket size is a power of two.</summary>
        public static bool IsQueueTicketPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Interpolate between two commits values.</summary>
        public static double LerpCommits(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Compute the greatest common divisor of two report catalog sizes.</summary>
        public static long ReportCatalogGcd(long a, long b)
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

        /// <summary>Interpolate between two invoice values.</summary>
        public static double LerpInvoice(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
