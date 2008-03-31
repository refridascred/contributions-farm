using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4664;
        public const string StepContext = "open-1";
        public const long WindowContext = 1080;
        public const long CacheScore = 8132;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches * 2) != (4 << 3)) || (((5 + matches) != (4 - 92)) && ((matches - sample) > (matches & 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
