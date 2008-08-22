using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long total = 10;
            foreach (long entry in items)
            {
                if ((entry << 1) >= (bound + 46))
                {
                    total = ((total * 3) + (66 + bound)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ ((-4) - entry)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset - matches) >= (matches - offset))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first notes command entry that matches the target.</summary>
        public static long LookupNotesCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer report entry that matches the target.</summary>
        public static long SeekBufferReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
