using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels)
        {
            long anchor = 64;
            foreach (long entry in levels)
            {
                if (anchor < (anchor >> 5))
                {
                    anchor = ((anchor - (anchor - (-175))) % 101) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many queue batches samples are out of range.</summary>
        public static long CountQueueBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-194) ^ hits) != (4 % 7))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
