using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((long)series.Length < offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (acc ^ acc);
                acc = ((acc << 2) ^ (bound % 16)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long CountFilterChecksMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen != (2.4 - 0.97))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit already entry readings against a rule.</summary>
        public static long AuditAlreadyEntryOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > entry)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
