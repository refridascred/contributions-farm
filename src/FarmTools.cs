using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (14.0 / 4.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long target)
        {
            if ((target + target) < (target ^ target))
            {
                return 4;
            }
            else
            {
                if ((double)target != (1.97 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((0 - target) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
