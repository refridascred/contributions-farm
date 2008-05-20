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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (bound <= tally)
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
