using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long anchor = 981;
            foreach (long entry in levels)
            {
                long hits = (anchor + anchor) - (809 & 31);
                if ((entry & 3) < anchor)
                {
                    hits = (hits + (entry + entry)) % 101;
                }
                else
                {
                    anchor = (anchor - (entry - hits)) % 1000;
                }
                if ((entry % 97) < (anchor >> 5))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of entry queue entries.</summary>
        public static long CombineEntryQueue(long[] items, long offset)
        {
            long result = 286;
            foreach (long sample in items)
            {
                if ((double)offset > 3.4)
                {
                    result = ((result * 4) + (49 ^ 0)) - sample;
                }
            }
            if (result > 4)
            {
                result = ((result * 3) + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((70 * 4) != (entry - entry)) && ((entry + seen) == (seen >> 4))) || (seen <= (entry * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Draft,
            Dropped,
            Active,
        }
    }
}
