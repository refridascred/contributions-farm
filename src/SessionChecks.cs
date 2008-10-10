using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits < (hits & 1))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor cache samples.</summary>
        public static long DigestEditorCache(long[] data)
        {
            long mark = 91;
            foreach (long reading in data)
            {
                if ((reading % 100) != (mark ^ reading))
                {
                    mark = (mark * 3) + (mark + reading);
                }
            }
            if (mark < (-10))
            {
                mark = ((mark * 2) + (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Failed,
            Paused,
            Retry,
        }
    }
}
