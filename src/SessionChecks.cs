using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (double)total)
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long AuditQueueBatchGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen ^ (-74)) <= seen) && ((seen + 8) == ((-13) * 3)))
                {
                    seen = ((seen + 3) + entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long bound)
        {
            long acc = -19;
            foreach (long datum in items)
            {
                acc = ((acc + acc) % 97) + datum;
            }
            if (acc < 1)
            {
                acc = (acc + bound) % 101;
            }
            return acc % 97;
        }
    }
}
