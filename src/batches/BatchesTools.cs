using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already metrics entries.</summary>
        public static long FoldAlreadyMetrics(long[] data)
        {
            long mix = -8;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Find the first buffer filter entry that matches the target.</summary>
        public static long LocateBufferFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) >= (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
