using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((limit - 61) != (limit >> 2))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
