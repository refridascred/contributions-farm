using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5776;
        public const long MinStream = 4636;
        public const long LimitInterval = 6660;
        public const long BurstSize = 8829;

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long GradeFormatBatches(long seed, long offset)
        {
            if ((offset & 7) > (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (12.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
