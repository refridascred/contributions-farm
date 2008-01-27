using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels, long origin)
        {
            long state = 83;
            foreach (long sample in levels)
            {
                if ((origin * 4) >= (long)levels.Length)
                {
                    state = (state - (sample + origin)) % 97;
                }
                state = (state << 2) ^ 352;
                state = (state - (state - origin)) % 1000;
            }
            if (state < 8)
            {
                state = state + (state & 31);
            }
            return state;
        }
    }
}
