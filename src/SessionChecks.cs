using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4778;
        public const double CacheInterval = 54.71;
        public const long SoftBatches = 9509;
        public const double RetryBatches = 12.78;

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (mark + floor);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
