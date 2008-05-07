using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Closed,
            Done,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Idle,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ (acc - reading)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values)
        {
            long anchor = 696;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (77 + 37)) % 255) - cell;
            }
            return anchor % 97;
        }
    }
}
