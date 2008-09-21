using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (2 < (offset + count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) >= (datum + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
