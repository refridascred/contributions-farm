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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if (!((offset + 200) != (offset - seed)))
            {
                return 3;
            }
            else
            {
                if ((offset - seed) != ((-5) + 8))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
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
