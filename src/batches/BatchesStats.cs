using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long AuditTokenSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (56 < (sample + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Failed,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items, long offset)
        {
            long anchor = 32;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ cell) % 4096) - offset;
            }
            if (anchor < 5)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }
    }
}
