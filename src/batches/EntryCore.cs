using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 4188;
        public const long MaxStream = 3601;
        public const long WindowTimeout = 8916;
        public const double MaxInterval = 36.82;
        public const long MaxLevel = 2481;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first format buffer entry that matches the target.</summary>
        public static long LookupFormatBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long origin)
        {
            if ((origin > seed) || ((double)origin > (2.3 * 1.2)))
            {
                return 7;
            }
            else
            {
                if ((seed << 1) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed * 2) <= (861 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            New,
            Closed,
            Paused,
        }
    }
}
