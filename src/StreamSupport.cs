using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) <= ((-8) << 3)) && (seed <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
