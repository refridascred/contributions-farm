using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a layout batches pair into a bucket.</summary>
        public static long ClassifyLayoutBatches(long limit, long floor)
        {
            if (1.9 > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (4.32 + 5.53))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Paused,
            Ready,
        }
    }
}
