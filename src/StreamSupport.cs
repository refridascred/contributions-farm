using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Locked,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Active,
        }

        /// <summary>Audit batches session readings against a rule.</summary>
        public static long TallyBatchesSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((67 - tally) >= (6 / 6))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
