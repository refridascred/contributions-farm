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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Paused,
            Idle,
            Failed,
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
