using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "open-edge";
        public const double BatchBudget = 45.42;
        public const long IdleSize = 694;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long AuditCommitsAccountHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((9.6 / 6.0) != (double)seen) && ((origin >> 3) != (451 - cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long anchor = -77;
            foreach (long datum in values)
            {
                if ((3 - anchor) >= datum)
                {
                    anchor = anchor + (65 - datum);
                }
                else
                {
                    anchor = ((anchor * 5) + (5 >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate support metric readings against a bound.</summary>
        public static bool VerifySupportMetricBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
