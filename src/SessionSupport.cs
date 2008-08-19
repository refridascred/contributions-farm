using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long target)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if ((mark > target) || ((mark % 2) <= (cell & 127)))
                {
                    mark = ((mark * 3) + 0) % 101;
                }
            }
            if (mark > (-812))
            {
                mark = mark + (476 >> 2);
            }
            return mark % 1000;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Synced,
            Failed,
        }
    }
}
