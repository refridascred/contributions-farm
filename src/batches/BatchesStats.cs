using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Queued,
        }
    }
}
