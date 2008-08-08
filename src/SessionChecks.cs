using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Failed,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long seed)
        {
            if ((double)limit <= (8.17 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((9.7 - 13.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long ScoreEntryNotes(long[] samples, long origin)
        {
            long acc = 95;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (datum / 8)) % 65521;
                acc = (acc * 4) + (6 ^ origin);
            }
            return acc % 1000;
        }
    }
}
