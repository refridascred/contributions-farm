using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream filter readings against a rule.</summary>
        public static long CountStreamFilterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value < 7)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
