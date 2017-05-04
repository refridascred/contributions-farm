using System;

namespace Common.Utilities
{
    /// <summary>Entry helpers.</summary>
    public static class Entry
    {
        /// <summary>Clamp a cluster batches value to a valid range.</summary>
        public static double ClampClusterBatches(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a cursor size is a power of two.</summary>
        public static bool IsCursorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Clamp a record value to a valid range.</summary>
        public static double ClampRecord(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Wrap a session order index into a fixed-size ring.</summary>
        public static int WrapSessionOrderIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
