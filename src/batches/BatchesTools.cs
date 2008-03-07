using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((6.9 > (double)count) && (count > (value << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 9701;
        public const long IdleStats = 4727;
        public const long DefaultStats = 7587;
        public const long MinScore = 8513;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Ready,
            New,
        }
    }
}
