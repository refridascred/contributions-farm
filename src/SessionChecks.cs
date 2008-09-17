using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                if (value >= (value - value))
                {
                    score = score + (value << 1);
                }
            }
            if (score > 22)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
