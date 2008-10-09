using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long AuditLayoutCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches * 2) == (matches % 64)))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Dropped,
            Retry,
        }

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
