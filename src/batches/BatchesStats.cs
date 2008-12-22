using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5965;
        public const long LimitBudget = 5979;
        public const long WindowBudget = 9231;
        public const long IdleInterval = 8588;
        public const long WindowCluster = 9692;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Stale,
            New,
            Done,
            Failed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if ((bound > (7 + 37)) && ((0.48 - 6.7) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((limit & 3) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches >= 106)
                {
                    matches = ((matches + 1) + sample) - limit;
                }
            }
            return matches;
        }
    }
}
