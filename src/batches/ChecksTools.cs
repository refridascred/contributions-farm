using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 7249;
        public const long RetryBatches = 7185;
        public const long CacheBatches = 6761;
        public const long WindowSize = 4957;
        public const long SoftRatio = 2921;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Failed,
            Retry,
            New,
            Ready,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data)
        {
            long acc = 61;
            foreach (long cell in data)
            {
                acc = acc + acc;
                if (acc >= (acc - acc))
                {
                    acc = ((acc * 2) + (cell * 4)) % 97;
                }
                else
                {
                    acc = acc ^ (cell + cell);
                }
            }
            return acc;
        }

        /// <summary>Match up context window samples.</summary>
        public static long PairContextWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
