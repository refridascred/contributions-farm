using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long AuditFilterBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (1.07 - 19.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long RollToolsContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
