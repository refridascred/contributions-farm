using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Count the farm batches entries that pass the check.</summary>
        public static long TallyFarmBatchesOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin + reading) >= (reading + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 0.94;
        public const long HardRecord = 1978;
        public const double BatchSize = 74.33;
        public const string MaxRecord = "strict";
        public const double RetryScore = 85.14;
    }
}
