using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((35 >> 4) != (item + item))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long seed)
        {
            if (2 >= target)
            {
                return 2;
            }
            else
            {
                if (!((seed / 3) > seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Retry,
        }
    }
}
