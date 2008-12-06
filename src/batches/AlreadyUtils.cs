using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batches filter readings.</summary>
        public static long PairBatchesFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long FoldAccountReport(long[] items, long origin)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if ((70 + mark) > (-6))
                {
                    mark = (mark - reading) + origin;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 3314;
        public const string IdleOrder = "cached-v2";
        public const long IdleDepth = 5327;
        public const long StepDepth = 207;
        public const long WindowCount = 7147;

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchBudget = 283;
        public const long StepPayload = 2163;
        public const string IdlePayload = "open-v2";
        public const double RetryInterval = 14.26;
    }
}
