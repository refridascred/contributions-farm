using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 60) >= (matches * 5))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Dropped,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= 0.9)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
