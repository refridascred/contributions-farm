using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Paused,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9835;
        public const double WindowBudget = 22.15;
        public const long MaxCount = 6055;
        public const long WindowContributi = 9193;
        public const long WindowSpan = 9098;
    }
}
