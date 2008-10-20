using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            New,
            Ready,
            Paused,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 2)) % 65521;
            }
            if (anchor > 90)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
