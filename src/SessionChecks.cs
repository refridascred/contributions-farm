using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data)
        {
            long result = 7;
            foreach (long item in data)
            {
                if (!(item > result))
                {
                    result = result - (item >> 1);
                }
            }
            return result % 4096;
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
