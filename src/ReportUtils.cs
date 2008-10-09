using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long acc = 74;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry / 3)) % 65521;
                if ((entry << 2) != (entry << 3))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = acc + (offset & 63);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7929;
        public const long HardTools = 2420;
        public const double MaxInterval = 87.44;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
