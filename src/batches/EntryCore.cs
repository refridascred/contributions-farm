using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8461;
        public const long WindowDepth = 7286;
        public const long MaxDepth = 6301;
        public const long SoftDepth = 5227;
        public const double BatchScore = 67.38;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long step)
        {
            long next = bound - step;
            if ((step ^ next) >= next)
            {
                return 4;
            }
            else
            {
                if ((next - bound) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) > (378 ^ 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
