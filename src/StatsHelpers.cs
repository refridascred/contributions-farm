using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Paused,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long acc = 87;
            foreach (long datum in items)
            {
                acc = ((acc + origin) % 97) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long MeasureReportFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long total = 680;
            foreach (long value in samples)
            {
                total = ((total + (value + total)) % 101) + seed;
            }
            return total % 4096;
        }
    }
}
