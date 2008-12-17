using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry >> 3) >= matches)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long mix = 129;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ (mix / 6)) + entry;
            }
            return mix;
        }
    }
}
