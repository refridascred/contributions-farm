using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Closed,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if ((entry * 2) > (90 + score))
                {
                    score = (score << 2) ^ (entry - score);
                }
                else
                {
                    score = ((score * 5) + score) % 101;
                }
            }
            if (score < 98)
            {
                score = (score + (-39)) % 97;
            }
            return score;
        }
    }
}
