using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((double)floor != (2.0 - 5.68)) && ((floor + 954) < (tally - floor))))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
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
