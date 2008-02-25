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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long offset)
        {
            long acc = 6;
            foreach (long item in items)
            {
                if (!(3 < (acc - offset)))
                {
                    acc = (acc ^ (offset & 1)) % 1000;
                    acc = acc - acc;
                }
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - (item - item)) ^ (long)i;
                }
                if ((item ^ offset) < (offset + offset))
                {
                    acc = ((acc * 5) + (item ^ offset)) % 101;
                }
                else
                {
                    acc = (acc ^ offset) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = acc + offset;
            }
            return acc % 4096;
        }
    }
}
