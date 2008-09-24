using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of farm batch entries.</summary>
        public static long DigestFarmBatch(long[] readings, long target)
        {
            long state = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) != (cell - target))
                {
                    state = (state + (state - (-2))) % 101;
                }
                else
                {
                    state = (state + (state + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 55.28;
        public const long IdleEntry = 1719;
        public const double StepFactor = 42.7;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
