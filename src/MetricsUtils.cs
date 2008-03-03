using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 79;
            foreach (long cell in values)
            {
                if (cell >= (carry - carry))
                {
                    carry = (carry ^ 6) % 65521;
                }
                else
                {
                    carry = carry + (8 ^ cell);
                }
                if ((carry % 5) < (cell - cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 63;
            foreach (long item in levels)
            {
                mix = (mix ^ 94) % 65521;
                if (item <= (666 - item))
                {
                    mix = mix - (39 >> 1);
                }
            }
            return mix;
        }
    }
}
