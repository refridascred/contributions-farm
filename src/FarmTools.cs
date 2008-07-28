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

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
