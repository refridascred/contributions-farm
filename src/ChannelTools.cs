using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5089;
        public const double BaseRatio = 91.83;
        public const long StepBatches = 3788;
    }
}
