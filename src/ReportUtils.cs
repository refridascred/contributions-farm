using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((double)sample != (5.0 + 9.0)) || ((double)sample < (double)tally)) || (((9.0 * 6.0) >= (6.9 / 7.0)) && ((818 & 1) != (tally >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryTimeout = 77.45;
        public const long SoftTimeout = 2949;
        public const string IdleGraph = "standard-v2";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
