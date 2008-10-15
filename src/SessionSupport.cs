using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long ScoreChannelAccount(long[] samples)
        {
            long mark = 822;
            foreach (long reading in samples)
            {
                if ((reading ^ mark) == (mark + reading))
                {
                    mark = (mark << 3) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Failed,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
