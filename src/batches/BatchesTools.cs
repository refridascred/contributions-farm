using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((2.0 + 20.0) <= (double)count)
                {
                    count = ((count + 1) ^ item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Pending,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Active,
            Done,
        }
    }
}
