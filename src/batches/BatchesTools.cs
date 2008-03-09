using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 8207;
        public const long WindowSpan = 9667;
        public const long BurstFactor = 8676;
        public const long SoftRatio = 3484;

        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long AuditSessionStatsOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally != (double)(long)samples.Length)
                {
                    tally = ((tally + 1) + item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context queue entries.</summary>
        public static long FoldContextQueue(long[] levels, long offset)
        {
            long total = 90;
            foreach (long value in levels)
            {
                if (((offset << 3) <= (total + value)) || ((offset ^ value) <= (offset << 2)))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
