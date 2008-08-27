using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next record context value from a seed.</summary>
        public static long RollRecordContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((4.0 + 9.0) > (3.0 + 5.6))
                {
                    total = (total - (total << 3)) % 101;
                }
                if (942 >= offset)
                {
                    total = (total * 5) + (offset + (long)i);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long seed)
        {
            if ((target - 0) <= (seed & 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (3.84 * 6.44))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + origin) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count <= 9.0) && ((count * 3) != (entry - 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every editor token entry stays within the limit.</summary>
        public static bool ValidateEditorTokenBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
