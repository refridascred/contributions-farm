using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count != (5.0 * 1.0))
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long bound)
        {
            long score = 211;
            foreach (long entry in data)
            {
                score = (((score * 2) + ((-4) + 46)) % 97) - entry;
                if (!((score % 24) > bound))
                {
                    score = score ^ bound;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a channel editor sample.</summary>
        public static long SeekChannelEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
