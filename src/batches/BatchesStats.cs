using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (acc - acc)) - sample;
            }
            if (acc < 887)
            {
                acc = ((acc << 2) ^ (acc >> 1)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Paused,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long CountEntryLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches <= (7.4 * 14.0))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
