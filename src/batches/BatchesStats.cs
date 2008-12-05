using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((777 / 2) < (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Failed,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((sample / 6) >= (carry >> 5))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) - limit;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}
