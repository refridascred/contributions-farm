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

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
