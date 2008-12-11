using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "strict-v2";
        public const double SoftOrder = 47.09;
        public const long SoftSize = 3048;

        /// <summary>Roll a queue graph counter forward.</summary>
        public static long IterateQueueGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 2) ^ seed) % 1000;
                if (!((total >> 3) <= ((long)i ^ (long)i)))
                {
                    total = (total << 3) ^ ((long)i >> 3);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long offset)
        {
            if (!((7.0 / 4.0) <= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((18.0 * 5.46) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9915;
        public const long RetryFilter = 1419;
        public const long WindowFilter = 956;
    }
}
