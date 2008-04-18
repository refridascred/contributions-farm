using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((14.0 - 9.0) != (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((-926) >> 5) <= matches)
                {
                    matches = ((matches + 1) + sample) - origin;
                }
            }
            return matches;
        }
    }
}
