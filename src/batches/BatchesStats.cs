using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)4 > (double)origin)
                {
                    anchor = (anchor + (origin / 6)) % 4096;
                }
                if (!(origin >= (87 & 15)))
                {
                    anchor = ((anchor * 2) + (anchor >> 5)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
