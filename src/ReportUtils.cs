using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (offset - (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a stats window counter forward.</summary>
        public static long DeriveStatsWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
