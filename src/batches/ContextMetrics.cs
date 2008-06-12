using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((bound - bound) != (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = carry + (95 >> 3);
                if (!((carry >> 5) > ((long)i + target)))
                {
                    carry = (carry * 4) + ((long)i * 2);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "legacy-v2";
        public const long BatchRatio = 5570;
        public const string RetryBudget = "legacy";
        public const long BurstLevel = 5062;
        public const long BurstAccount = 1226;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9823;
        public const long StepRatio = 6035;
        public const string DefaultBatches = "latest";
    }
}
