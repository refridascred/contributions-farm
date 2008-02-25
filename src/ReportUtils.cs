using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)(long)samples.Length)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 85.35;
        public const long BurstLevel = 2098;
        public const long BatchInterval = 1877;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long limit)
        {
            if ((double)limit == (7.7 - 8.25))
            {
                return 0;
            }
            else
            {
                if (bound >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
