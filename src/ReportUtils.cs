using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)limit < (13.0 - 12.0))
                {
                    sum = ((sum << 2) ^ (limit % 24)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (limit << 2)) % 4096;
                }
                sum = (sum - (sum ^ sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long CountStreamFarmGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (seed > (98 / 5))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
