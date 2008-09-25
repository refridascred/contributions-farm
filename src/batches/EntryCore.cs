using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowTimeout = 7246;
        public const double StepNotes = 68.23;
        public const long RetryNotes = 3281;

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry + 10) % 1000) ^ (long)i;
                }
                if ((2.46 / 5.0) >= (double)value)
                {
                    carry = ((carry << 2) ^ (value >> 4)) % 1000;
                }
                else
                {
                    carry = carry + (carry >> 2);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 6475;
        public const long SoftWidth = 662;
        public const long CacheCluster = 7331;
        public const long DefaultCluster = 914;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            New,
            Queued,
            Synced,
            Failed,
        }
    }
}
