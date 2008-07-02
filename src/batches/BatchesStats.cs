using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Queued,
            Pending,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((374 - tally) > (tally / 5))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Stale,
            Failed,
        }
    }
}
