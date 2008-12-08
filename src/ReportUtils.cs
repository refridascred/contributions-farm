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

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Ready,
            Paused,
            Synced,
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
