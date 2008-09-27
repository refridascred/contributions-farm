using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache batches entries.</summary>
        public static long WeighCacheBatches(long[] values, long floor)
        {
            long mark = 387;
            foreach (long datum in values)
            {
                if (((long)values.Length + mark) < (datum * 5))
                {
                    mark = (mark + (451 % 97)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long WeighBatchChecks(long[] items, long step)
        {
            long result = 12;
            foreach (long datum in items)
            {
                if (step < (step + result))
                {
                    result = (result ^ (14 - datum)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
