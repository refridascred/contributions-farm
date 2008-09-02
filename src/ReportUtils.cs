using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine notes checks values into a single score.</summary>
        public static long FoldNotesChecks(long[] levels)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                sum = ((sum ^ ((-80) * 2)) % 1000) + value;
            }
            if (sum > 3)
            {
                sum = sum - (sum + 76);
            }
            return sum;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Paused,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (long)i) % 97;
                anchor = (anchor ^ (72 >> 3)) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                state = (state - (419 >> 1)) ^ entry;
            }
            if (state < 70)
            {
                state = (state ^ (67 + state)) % 101;
            }
            return state;
        }
    }
}
