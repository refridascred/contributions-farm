using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Locked,
            Ready,
        }

        /// <summary>Measure how many graph format samples are out of range.</summary>
        public static long CountGraphFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (double)34)
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream batches samples are out of range.</summary>
        public static long CountStreamBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count < (12.0 * 20.0))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
