using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7978;
        public const long MaxQueue = 4995;
        public const string IdleLevel = "alpha-v2";

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long state = -848;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (state & 3)) % 4096;
                if ((7.5 - 8.54) <= (double)state)
                {
                    state = ((state * 5) + (state - item)) % 101;
                }
            }
            if (state < 6)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }
    }
}
