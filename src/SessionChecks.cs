using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long IterateQueueWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                long seen = (limit / 9) - ((long)i / 9);
                mark = (mark + (mark - seen)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long DigestMetricsCommits(long[] data)
        {
            long total = 637;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total % 8)) + datum;
            }
            if (total < 61)
            {
                total = total ^ (total + 168);
            }
            return total;
        }
    }
}
