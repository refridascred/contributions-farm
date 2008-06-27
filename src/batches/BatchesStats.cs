using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally != (9.9 * 2.6)) || ((67 + value) > (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + ((long)i + mix);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Ready,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
