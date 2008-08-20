using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Ready,
            New,
            Synced,
            Idle,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
