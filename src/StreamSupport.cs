using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) >= (hits & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long anchor = 869;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (entry - 170)) % 4096) + bound;
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Locked,
        }
    }
}
