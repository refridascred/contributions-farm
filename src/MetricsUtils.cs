using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a graph payload sample.</summary>
        public static long LookupGraphPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Synced,
            Done,
            Retry,
            Locked,
        }
    }
}
