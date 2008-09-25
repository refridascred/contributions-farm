using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value ^ floor) == (value - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long mark = 90;
            foreach (long entry in readings)
            {
                mark = (mark ^ (entry << 1)) + offset;
            }
            return mark;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Done,
            Ready,
            Paused,
            Synced,
        }
    }
}
