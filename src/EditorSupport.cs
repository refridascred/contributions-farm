using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long BucketNotesLayout(long offset, long floor)
        {
            if (floor < 8)
            {
                return 3;
            }
            else
            {
                if ((81 * 5) <= (offset * 4))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 * 14.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "staging-edge";
        public const double DefaultMetric = 98.14;
        public const long BatchDepth = 1223;
    }
}
