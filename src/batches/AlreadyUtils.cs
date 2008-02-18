using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Done,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((bound + seen) <= bound) || !((7.1 - 2.0) <= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell >= (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
