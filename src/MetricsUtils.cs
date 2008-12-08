using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long step)
        {
            long mark = 690;
            foreach (long item in series)
            {
                if ((step + step) < (item / 5))
                {
                    mark = (mark ^ item) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ item) % 255;
                }
            }
            if (mark > (-375))
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinDepth = 1964;
        public const long HardSize = 5343;
        public const long RetryTimeout = 1320;
        public const string HardTimeout = "local";
        public const long BaseBatches = 7151;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry == (3.9 - 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Locked,
            Ready,
            Draft,
            Retry,
        }
    }
}
