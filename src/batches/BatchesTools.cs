using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((2 - cell) >= (cell + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((245 / 5) != (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Ready,
            Pending,
            Paused,
            Closed,
        }
    }
}
