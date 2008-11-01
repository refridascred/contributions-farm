using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long CountBatchChecksMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < (reading >> 1))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Draft,
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + (target ^ (long)i);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
