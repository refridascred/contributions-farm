using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long TallyToolsChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)tally < 8.4)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
            Synced,
            Dropped,
        }
    }
}
