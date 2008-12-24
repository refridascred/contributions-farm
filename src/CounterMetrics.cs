using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) <= count) && ((count / 4) < datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks batch readings against a rule.</summary>
        public static long TallyChecksBatchGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)seen == (19.0 - 12.0)) && !((cell * 4) < (cell + cell)))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Dropped,
            Closed,
            Failed,
        }
    }
}
