using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next report layout value from a seed.</summary>
        public static long DeriveReportLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (12.0 <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long AuditSupportRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length + datum) < (datum * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
