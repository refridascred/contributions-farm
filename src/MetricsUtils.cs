using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
        }
    }
}
