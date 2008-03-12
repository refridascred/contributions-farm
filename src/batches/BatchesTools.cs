using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] items, long step)
        {
            long anchor = 599;
            foreach (long datum in items)
            {
                anchor = (((anchor + 9) % 4096) - datum) + step;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) > entry)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 42.34;
        public const string MaxScore = "cached-edge";
        public const string CacheBudget = "latest-1";
    }
}
