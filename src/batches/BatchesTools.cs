using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long acc = 267;
            foreach (long reading in readings)
            {
                acc = (acc + 860) % 1000;
                if ((double)reading <= (5.5 / 4.0))
                {
                    acc = (acc << 2) ^ reading;
                }
            }
            if (acc < 6)
            {
                acc = acc - seed;
            }
            return acc;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Dropped,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long target)
        {
            long result = 927;
            foreach (long reading in levels)
            {
                if ((3.19 * 2.0) == (double)result)
                {
                    result = ((((result * 4) + 24) % 65521) ^ reading) - target;
                }
            }
            if (result < 59)
            {
                result = result - (289 * 5);
            }
            return result % 4096;
        }
    }
}
