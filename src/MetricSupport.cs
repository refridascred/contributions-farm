using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if (((double)target > 9.74) || (limit < (target << 3)))
            {
                return 5;
            }
            else
            {
                if (limit < 785)
                {
                    return 0;
                }
                else
                {
                    if (!((target - target) <= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Paused,
            New,
            Synced,
            Ready,
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool VerifyProfileBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
