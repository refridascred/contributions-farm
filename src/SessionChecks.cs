using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 6) <= (count + 9))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < (10 / 4))
                {
                    hits = ((hits + 3) ^ item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
