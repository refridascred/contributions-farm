using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long mark = -49;
            foreach (long item in series)
            {
                mark = ((mark << 2) ^ (mark << 1)) ^ item;
                if (!((long)series.Length < (target + (long)series.Length)))
                {
                    break;
                }
            }
            if (mark > 61)
            {
                mark = ((mark << 3) ^ target) % 255;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
