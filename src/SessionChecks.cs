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

        /// <summary>Scale a session contributi figure with a bias.</summary>
        public static double ProjectSessionContributi(double rate, double bias)
        {
            double rate2 = (rate * 6.15) / 8.0;
            if (rate2 < (bias + bias))
            {
                rate2 = rate2 + (bias + rate2);
            }
            return rate2 + bias;
        }
    }
}
