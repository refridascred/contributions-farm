using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long BucketAccountContext(long limit, long offset)
        {
            long next = limit + offset;
            if ((4.4 - 8.5) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((4.42 + 5.9) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (734 >= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((5 + cell) >= (40 + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultBudget = 5880;
        public const double IdleBudget = 46.47;
        public const long RetryCommand = 5552;
    }
}
