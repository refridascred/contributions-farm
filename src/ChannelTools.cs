using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long score = 49;
            foreach (long datum in levels)
            {
                if ((score + score) <= (-15))
                {
                    score = score - (datum + score);
                }
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long target)
        {
            if ((double)target < (5.4 * 2.92))
            {
                return 6;
            }
            else
            {
                if (164 < (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
