using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((offset + seed) < offset)
            {
                return 8;
            }
            else
            {
                if (7 < (edge - offset))
                {
                    return 5;
                }
                else
                {
                    if ((4.1 + 20.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
