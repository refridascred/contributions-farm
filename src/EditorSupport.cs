using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ (item >> 2)) - offset;
                mark = mark - (item - (-839));
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 711;
        public const string HardScore = "open-edge";
        public const string BaseSession = "latest-edge";

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Idle,
            New,
            Paused,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
