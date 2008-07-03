using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the filter tools entries that pass the check.</summary>
        public static long AuditFilterToolsOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum ^ origin) <= ((long)values.Length ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Retry,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long total = 611;
            foreach (long cell in items)
            {
                if (((total << 2) > floor) && ((double)floor > (9.6 / 5.0)))
                {
                    total = (total - (cell - floor)) % 101;
                }
                if ((double)cell >= (double)floor)
                {
                    total = ((total * 4) + (45 % 97)) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)items.Length + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double SmoothEditorProfile(double ratio, double span)
        {
            double gain = span;
            return (gain + 8.6) + ratio;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
