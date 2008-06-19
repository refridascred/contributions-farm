using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of checks queue readings.</summary>
        public static long FoldChecksQueue(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + ((long)i * 2)) % 1000;
                    mark = (mark - (item % 2)) % 97;
                }
                mark = ((mark << 3) ^ (item - mark)) % 1000;
            }
            if (mark < 517)
            {
                mark = ((mark * 3) + (mark - mark)) % 1000;
            }
            return mark;
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
