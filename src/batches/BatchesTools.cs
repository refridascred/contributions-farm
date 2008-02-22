using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long anchor = 229;
            foreach (long sample in items)
            {
                if (anchor >= offset)
                {
                    anchor = anchor + (sample % 5);
                }
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6468;
        public const long StepBuffer = 7637;
        public const double BatchLevel = 12.78;
        public const long LimitLevel = 619;
        public const long StepCount = 9965;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
