using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 94;
            foreach (long reading in samples)
            {
                state = (state * 5) + state;
                state = ((state << 2) ^ (9 - reading)) % 65521;
            }
            return state % 65521;
        }
    }
}
