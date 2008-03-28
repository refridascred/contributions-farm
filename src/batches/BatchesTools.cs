using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((676 & 7) != (floor + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long sum = 52;
            foreach (long sample in readings)
            {
                if (((sum - sample) >= (sample + sum)) && ((sample & 1) == (sum + sample)))
                {
                    sum = sum - (sample - 6);
                }
            }
            return sum % 4096;
        }
    }
}
