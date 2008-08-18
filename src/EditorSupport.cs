using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long TallyToolsCounterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Active,
            Failed,
            Done,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Retry,
            Locked,
            Synced,
        }
    }
}
