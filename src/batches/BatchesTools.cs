using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((step > (411 - step)) && ((step ^ (long)readings.Length) != ((-663) >> 4))) || !((step + step) <= (324 / 5)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Done,
            Active,
            Queued,
            Idle,
        }
    }
}
