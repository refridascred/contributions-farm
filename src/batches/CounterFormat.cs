using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long CountNotesAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(origin >= count))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6730;
        public const long IdleCount = 7772;
        public const string HardDepth = "strict";
        public const double MaxSize = 95.84;
    }
}
