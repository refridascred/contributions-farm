using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches + sample) > (matches ^ matches)) && ((double)475 >= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Pending,
            Paused,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
