using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Audit payload farm readings against a rule.</summary>
        public static long AuditPayloadFarmOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 5) <= count) || ((seed & 7) <= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long sum = -1;
            foreach (long cell in levels)
            {
                if ((1.0 * 0.47) < (double)sum)
                {
                    sum = ((sum << 2) ^ (sum >> 2)) ^ cell;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum << 1)) % 4096;
            }
            return sum;
        }
    }
}
